// Fernando Aguilar
// 10-27-22
// Restaurant Picker Endpoint
// The program takes mini challenge 9 and converts it into an API program. 
// The user inputs what kind of food they want to eat and the program outputs
// one of ten different restaurant options based on what kind of food they choose.
// Peer Reviewed By: N. HARRISON WILKINS : GREAT WORK!!! CLEAR CODING WITH NICE SPACING , MAKES IT EASY TO READ , DATA VALIDATION GVES BACK YOUR ANSWER IF IT DOES NOT MEET A CONDITION , OVERALL REALLY GREAT WORK!!!!


using Microsoft.AspNetCore.Mvc;

namespace AguilarFRestaurantPickerEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantPickerController : ControllerBase
{

    [HttpGet]
    [Route("myChoice/{foodChoice}")]

    public string restaurantPicker(string foodChoice)
    {

        bool restPick = false;
        bool numInvalid;
        int wrongAns = 0;

        while (restPick == false)
        {
            numInvalid = Int32.TryParse(foodChoice, out wrongAns);

            if (numInvalid == false)
            {
                restPick = true;

                Random rndNum = new Random();
                long num = rndNum.Next(1, 10);

                switch (foodChoice)
                {
                    case "mexican":

                        switch (num)
                        {
                            case 1:
                                return " Freddy's Restaurant and Bar ";


                            case 2:
                                return " Pancho Villa's Taqueria ";


                            case 3:
                                return " Celia's ";


                            case 4:
                                return " Luna Eterna Bar and Grill ";


                            case 5:
                                return " La Perla";


                            case 6:
                                return " Taqueria Chapala ";


                            case 7:
                                return " Antojitos ";


                            case 8:
                                return " Quesabirrias Xibalba";


                            case 9:
                                return " El Toro ";


                            case 10:
                                return " The taco truck by the Teacher's College ";


                            default:

                                break;
                        }

                        break;
                                    case "chinese":

                        switch (num)
                        {
                            case 1:
                                return " The Chopstick ";


                            case 2:
                                return " China Palace Restaurant ";


                            case 3:
                                return " Yen Du Restaurant ";


                            case 4:
                                return " Dave Wong's Restaurant ";


                            case 5:
                                return " Golden Palace Buffet ";


                            case 6:
                                return " Panda Express ";


                            case 7:
                                return " Tasty Pot ";


                            case 8:
                                return " Sushi House Buffet ";


                            case 9:
                                return " Saigon Bowl Noodle House ";


                            case 10:
                                return " Oceanic Restaurant ";


                            default:

                                break;
                        }

                        break;

                    case "american":

                        switch (num)
                        {
                            case 1:
                                return " Darby Dan's ";


                            case 2:
                                return " Burger King ";


                            case 3:
                                return " Ed's Diner ";


                            case 4:
                                return " Denny's ";


                            case 5:
                                return " Papa Tom's Restaurant ";


                            case 6:
                                return " McDonalds ";


                            case 7:
                                return " Subway ";


                            case 8:
                                return " Keystone Family Diner ";


                            case 9:
                                return " Annie's Diner and Pies ";


                            case 10:
                                return " Popeye's ";


                            default:

                                break;
                        }

                        return foodChoice;
                }

            }
        }
        return foodChoice;
    }
}