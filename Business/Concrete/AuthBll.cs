﻿using Business.Abstract;
using Business.Constants.BllMethodMessages;
using Business.ValidationRules.fluentValidation;
using Core.Aspects.Autofac.validation;
using Core.DataResult.Abstract;
using Core.DataResult.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Hashing;
using Core.Utilities.Security.Jwt;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class AuthBll : IAuthBll
    {
        IuserBll _user;
        ITokenHelper _token;
        IroleBll _role;
        public AuthBll(IuserBll user, ITokenHelper token, IroleBll role)
        {
            _user = user;
            _token = token;
            _role = role;
        }
        public IDataResult<AccessToken> createAccessToken(user user)
        {
            List<role> role = _role.getAllByUserId(user.Id).data;
            var Token = _token.CreateToken(user, role);
            return new DataSuccessResult<AccessToken>(Token);
        }


        public IDataResult<user> login(loginDto login)
        {
            var user = _user.getOneByEmail(login.userEmail);
            if (!user.success)
                return new DataErrorResult<user>(bllMessages.notFoundEmail);
            if (!hashHelper.verifyPasswordHash(login.password, user.data))
            {
                return new DataErrorResult<user>(bllMessages.wrongPassword);
            }
            return new DataSuccessResult<user>(user.data, bllMessages.successfullLogin);
        }
        //   [TransactionAspect]
        [ValidationAspect(typeof(productValidation))]
        public IResult register(registerDto register)
        {
            byte[] passwordHash;
            byte[] passwordSalt;
            user user = new user();
            hashHelper.createPasswordHash(register.password, out passwordHash, out passwordSalt);
            user.passwordHash = passwordHash;
            user.passwordSalt = passwordSalt;
            user.userEmail = register.userEmail;
            user.surname = register.surname;
            user.name = register.name;
            user.userName = register.userName;
            user.isActive = true;
            IResult checkErrors = BusinessRules.Run(
                isExistEmail(register.userEmail), isExistUserName(register.userName));
            if (checkErrors != null)
            {
                return checkErrors;
            }


            var result = _user.addUser(user);
            if (result.success)
            {
                _role.addRoleToUser(2, user.Id);
                return new SuccessResult(result.message);
            }
            else
                return new ErrorResult(result.message);

        }
        IResult isExistEmail(string email)
        {
            var isExistEmail = _user.getOneByEmail(email);
            if (isExistEmail.success)
                return new ErrorResult(bllMessages.emailAlreadyUsed);
            return new SuccessResult();
        }
        IResult isExistUserName(string username)
        {
            var isUserNameExist = _user.getOneByUserName(username);
            if (isUserNameExist.success)
                return new ErrorResult(bllMessages.usernameAlreadyExist);
            return new SuccessResult();
        }

    }
}
