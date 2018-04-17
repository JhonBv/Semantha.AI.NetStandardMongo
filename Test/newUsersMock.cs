using Semantha.AI.BCL.MongoDB.Models.BindingModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public static class newUsersMock
    {
        public static CreateUserBindingModel AddMayra()
        {
            var model = new CreateUserBindingModel
            {

                FirstName = "Mayra",
                LastName = "Palomino",
                BirthDate = "20/05/1991",
                email = "mayrapalomino49@gmail.com",
                userName = "paloma",
                PhoneNumber = "07376095124",
                AgeRange = "25-35",
                dateAdded = DateTime.Today.ToShortDateString(),
                address = new CreateAddressBindingModel
                {
                    lineOne = "78 Overstone Road",
                    lineTwo = "",
                    city = "London",
                    lineThree = "",
                    postCode = "W6 0AA",
                    country = "UK",
                    isbilling = true,
                    isshipping = true,
                }
            };

            return model;
        }//mayra
        public static CreateUserBindingModel AddJhon()
        {
            var model = new CreateUserBindingModel
            {

                FirstName = "Jhon",
                LastName = "Barreiro",
                BirthDate = "06/09/1986",
                email = "jhonb@gmail.com",
                userName = "jjbarr",
                PhoneNumber = "07376095123",
                AgeRange = "25-35",
                dateAdded = DateTime.Today.ToShortDateString(),
                address = new CreateAddressBindingModel
                {
                    lineOne = "78 Overstone Road",
                    lineTwo = "",
                    city = "London",
                    lineThree = "",
                    postCode = "W6 0AB",
                    country = "UK",
                    isbilling = true,
                    isshipping = true,
                }
            };

            return model;
        }//add jhon

        public static CreateUserBindingModel AddSam()
        {
            var model = new CreateUserBindingModel
            {

                FirstName = "Samuel",
                LastName = "Barreiro",
                BirthDate = "06/09/1986",
                email = "samuel@gmail.com",
                userName = "samito",
                PhoneNumber = "07376095123",
                AgeRange = "17-21",
                dateAdded = DateTime.Today.ToShortDateString(),
                address = new CreateAddressBindingModel
                {
                    lineOne = "78 Overstone Road",
                    lineTwo = "",
                    city = "London",
                    lineThree = "",
                    postCode = "W6 0AE",
                    country = "UK",
                    isbilling = true,
                    isshipping = true,
                }
            };
            return model;
        }//add Sam


        public static CreateUserBindingModel AddLuis()
        {
            var model = new CreateUserBindingModel
            {

                FirstName = "Luis A",
                LastName = "Torres",
                BirthDate = "06/09/1976",
                email = "jhonb@gmail.com",
                userName = "lacho",
                PhoneNumber = "07376095123",
                AgeRange = "36-45",
                dateAdded = DateTime.Today.ToShortDateString(),
                address = new CreateAddressBindingModel
                {
                    lineOne = "79 Overstone Road",
                    lineTwo = "",
                    city = "London",
                    lineThree = "",
                    postCode = "W6 0EE",
                    country = "UK",
                    isbilling = true,
                    isshipping = true,
                }
            };

            return model;
        }//add lacho
    }
}
