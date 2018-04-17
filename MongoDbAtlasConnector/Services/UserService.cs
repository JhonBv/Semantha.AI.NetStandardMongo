using MongoDB.Bson;
using MongoDbAtlasConnector.Factories;
using Semantha.AI.BCL.MongoDB.Models.BindingModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbAtlasConnector.Services
{
    public static class UserService
    {
        /// <summary>
        /// Add new user. Validate model and if username/email has not been taken, creates a new user record, otherwys, returns an invalid message
        /// </summary>
        /// <param name="user"></param>
        /// <param name="collection"></param>
        /// <returns>Ok if successful, </returns>
        public static string AddNewUser(CreateUserBindingModel user, string collection)
        {
            string response = "Ok";

            bool emailExists = FindUserEmail.EmailExists(user.email, collection);
            bool userNameExists = FindUserName.UsernameExists(user.userName, collection);

            if (emailExists == false && userNameExists == false)
            {
                //First build the user via the factory
                BsonDocument userDoc = UserFactory.CreateMongoUser(user);
                var _repo = new UserRepository();

                return _repo.AddUSer(userDoc, collection);
            }
            else 
            {
                if (userNameExists == true) { response = "Username already taken"; }
                else if (emailExists == true) response = "Email address already taken";
            }
            return response;
        }



        static bool checkForEmail(string email, string collection)
        {

            return FindUserEmail.EmailExists(email, collection);
        }
    }
}
