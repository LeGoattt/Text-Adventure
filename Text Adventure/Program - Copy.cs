using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text.Json;
using System.Threading;

namespace TextAdventure
{
    internal struct GeneralInfo
    {
        
    }
    
   
    internal struct Parasite
    {
        public int parasiteControl;
        public string parasiteName;
    }
    internal class Programs
    {
        static void lblal(string text, int delay = 30) //Hey look. lblal means letter by letter line. WOW
        {
            lbl(text, delay);
            Console.WriteLine();
        }
        static void lbl(string text, int delay = 30) //its the thing I call with the good old lblal
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(delay);
            }
        }
        static string PromptPlayer() //Type. Do it. Type for me boy
        {

            string input;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            input = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            return input;
        }
        static void Main(string[] args) //I dont actually know why I'm doing this, why is it all here? What am I doing
        {
            StartMenu();
            Intro();
            Choices();
            callOut();
            callOutAgain();
            callOutYetAgain();
            CALLOUT();
            Struggle();
            struggleMore();
            struggleSomeMore();
            continueSearching();
            attemptToStand();
            FIREBALL();
            restAbit();
            stayPut();
            keepStaying();
            stayABitLonger();
            STAYPUT();
            sleep1();
            sleep2();
            sleep3();
            sleep4();
            helloDerek();


            

        }
        static void StartMenu()
        {
            lblal("oh hey, you wanna play this depressive game? Cool just type Start");
            lblal("EndingsWIP | Start", 0); //Its my start menu, yippeeeeee
            string choice = PromptPlayer();

            if (string.Compare(choice, "Start", true) == 0)
            {
                Intro();
            }
            else if (string.Compare(choice, "Endings", true) == 0)
            {
                Struggle();
            }
            else if (string.Compare(choice, "Hello Derek", true) == 0)
            {
                helloDerek();
            }
            else
            {
                lblal("are you? do you want to play orr did you mistype start. Here I'll just do it anyway");
                Intro();
            }
        }
        static void Intro()
        {
            lblal("...");
            Thread.Sleep(1000);
            lblal("...");
            Thread.Sleep(1000);
            lblal(". . . plop, plop, plop.");
            Thread.Sleep(1000);
            lblal("That's all you can hear, that's all you've been able to hear. For what feels as though an eternity.");
            Thread.Sleep(500);
            lblal("Shackled to a cold and wet wall, deep inside a damp cave- the lack of light engulfing you in darkness, the cold biting at your skin.");
            Thread.Sleep(500);
            lblal("All the while- That steady patter of droplets fall from above your head, right infront of you. This water being the only reason you've even survived this long.");
            Thread.Sleep(1500);

            Choices();
        }
        static void Choices()
        {
            lblal("All this crushing dread, you need to do something about it. But what?");
            lblal("Call Out | Struggle | Stay Put", 0);
            string choice = PromptPlayer();

            if (string.Compare(choice, "Call Out", true) == 0)
            {
                callOut();
            }
            else if (string.Compare(choice, "Struggle", true) == 0)
            {
                Struggle();
            }
            else if (string.Compare(choice, "Stay Put", true) == 0)
            {
                stayPut();
            }
            else
            {
                lblal("No, no that wouldn't work. Try something else");
                Choices();
            }
        }
        static void callOut()
        {
            lblal("You attempt to muster up the strength to make a noise. Anything- But the most that comes out is a pathetic hearse wheeze. Too weak, too starved to even scream.");
            lblal("Call Out Again | Struggle | Stay Put", 0);
            string choice = PromptPlayer();

            if (string.Compare(choice, "Call Out Again", true) == 0)
            {
                callOutAgain();
            }
            else if (string.Compare(choice, "Struggle", true) == 0)
            {
                Struggle();
            }
            else if (string.Compare(choice, "Stay Put", true) == 0)
            {
                stayPut();
            }
            else
            {
                lblal("That wasn't an option. Use your eyes Player");
                callOut();
            }


        }
        static void callOutAgain()
        {
            lblal("Despite this setback, a burst of determination pushes you forth. To get atleast a Sound out. Just one small sound that's all");
            Thread.Sleep(500);
            lblal("Gathering up all your strength, taking in the deepest breath you can muster- Gaining all your resolve only- To fail. Once again... Nothing changes");
            Thread.Sleep(500);
            lblal("You cant do a single thing. You cant scream I already told you that. What are you stupid? Dont try again, pick another option.");
            Thread.Sleep(250);
            lblal("Call Out yet Again | Struggle | Stay Put", 0);
            string choice = PromptPlayer();
            if (string.Compare(choice, "Call Out yet Again", true) == 0)
            {
                callOutYetAgain();
            }
            else if (string.Compare(choice, "Struggle", true) == 0)
            {
                Struggle();
            }
            else if (string.Compare(choice, "Stay Put", true) == 0)
            {
                stayPut();
            }
            else
            {
                lblal("You know, maybe all that screaming made you light headed. Read the options a bit better mkay? mkay");
                callOutAgain();

            }
        }
        static void callOutYetAgain()
        {
            lblal("Really? Still trying are we? A shame. But fine I'll allow it");
            Thread.Sleep(1000);
            lblal("You take a moment to think leaning forward you pool a decent cup of water into your mouth, drinking up whatever you can- trying to satisfy your aching, dry throat.");
            Thread.Sleep(500);
            lblal("With this newfound moisture in your system. You manage to make a noise.. Congrats.");
            Thread.Sleep(500);
            lblal("You screamt the most pathetic scream that has ever been made. A raspy, almost whistle like noise that tears from your lips shamefully.");
            Thread.Sleep(1500);
            lblal("What? Did you expect something to happen? Who would hear you down here? No one.");
            Thread.Sleep(500);
            lblal("GOOD JOB- You got ending #2. \"Wasting your time like an idiot\". Congrats.");
            lblal("Retry", -0);
            string choice = PromptPlayer();
            if (string.Compare(choice, "Retry", true) == 0)
            {
                StartMenu();
            }
            else if (string.Compare(choice, "CALL OUT", true) == 0)
            {
                CALLOUT();
            }
            else
            {
                lblal("Okay I guess you didn't realize that me prompting \"Retry\" was your directions. Had I known you were stupid I would have just done it for you, just like I am now");
                StartMenu();
            }

        }
        static void CALLOUT()
        {
            lblal("What? All Caps?? How'd you even know to do that huh? how many tries did it take? Or had I told you, or are you peaking at the code?");
            Thread.Sleep(100);
            lblal("Dont know. Either way what I do know is you wasted your time. x2");
            Thread.Sleep(500);
            lblal("Good Job. You got Secret Ending #2 \"Wasting your time. Like a dumbass\" Did you want more story? No. Fuck you");
            string choice = PromptPlayer();
            if (string.Compare(choice, "Retry", true) == 0)
            {
                StartMenu();
            }
            else
            {
                lblal("Yeah no seriously you had one option. You got the secret there isn't double secret endings. Just go- Get outta here");
                StartMenu();
            }
        }
        
        
        
        static void Struggle()
        {
            lblal("Feeling adventorous today. You attempt to struggle against the chains binding you to this harsh stone.");
            Thread.Sleep(1000);
            lblal("To no avail of course....");
            Thread.Sleep(500);
            lblal("Even if you were in good shape what hope have you to rip chains from a wall? Let alone in this weary state of yours.");
            Thread.Sleep(500);
            lblal("Struggle More | Stay Put | Call Out", 0);
            string choice = PromptPlayer();
            if(string.Compare(choice, "Struggle More", true) == 0)
            {
                struggleMore();
            }
            else if (string.Compare(choice, "Stay Put", true) == 0)
            {
                stayPut();
            }
            else if (string.Compare(choice, "Call Out", true) == 0)
            {
                callOut();
            }
            else
            {
                lblal("sorry, that wasn't an option. Try that again kay? Read it slower maybe");
                Struggle();
            }
        }
        static void struggleMore()
        {
            lblal("Despite this, despite me tellling you that you are weakened. You are bound to a cave wall by chains you continue to struggle.");
            Thread.Sleep(500);
            lblal("For reasons I am not privy to- Are you under the belief that anything will come from this?");
            Thread.Sleep(500);
            lblal("That the chains will suddenly snap under your feeble force?");
            Thread.Sleep(200);
            lblal("Struggle Some More | Stay Put | Call Out", 0);
            string choice = PromptPlayer();
            if (string.Compare(choice, "Struggle Some More", true) == 0)
            {
                struggleSomeMore();
            }
            else if(string.Compare(choice, "Stay Put", true) == 0)
            {
                stayPut();
            }
            else if(string.Compare(choice, "Call Out", true) == 0)
            {
                callOut();
            }
            else
            {
                lblal("Are you doing it on purpose? Are you trying to appear dyslexic? I gave you clear instruction.");
                struggleMore();
            }
        }
        static void struggleSomeMore()
        {
            lblal("Fine... You want something to happen? It will.");
            Thread.Sleep(1000);
            lblal("Under all the sudden jostling the, long forgotten rusted chains prove to have a weak link... Snapping.");
            Thread.Sleep(500);
            lblal("You fall face first into the cold harsh stone. Pain..");
            Thread.Sleep(500);
            lblal("Pain overshadowed by the joy you feel at finally being free-");
            Thread.Sleep(500);
            lblal("Ignoring the thick murky blood leaking from your nose. Creating puddle as you lay there- Seeping into your mouth.");
            Thread.Sleep(500);
            lblal("With all of the previous struggling you find yourself having a hard time sitting up... ");
            Thread.Sleep(500);
            lblal("After an undetermined amount of time being chained perfectly still. Your body isn't built for movement.. It's still just trying to survive");
            Thread.Sleep(500);
            lblal("Attempt to Stand | Take a bit to rest", 0);
            string choice = PromptPlayer();
            if (string.Compare(choice, "Attempt to Stand", true) == 0)
            {
                attemptToStand();
            }
            else if (string.Compare(choice, "Take a bit to rest", true) == 0)
            {
                takeABitToRest();
            }
            else
            {
                lblal("okay stupid. Maybe having two options was two much for you. Get it? Get the pun? Yeah? Great.");
                struggleSomeMore();
            }
        }
        static void attemptToStand()
        {
            lblal("You decide you should try and stand instead of laying there like a turd.");
            Thread.Sleep(500);
            lblal("So you do, you muster up all the remaining strength you can to slowly but surely wobble yourself up to your feet");
            Thread.Sleep(500);
            lblal("Stumbling forward falling to your knees, the brittle joints cracking against the stone cave floor. But you dont stop");
            Thread.Sleep(500);
            lblal("Determined to get to your feet you stand once more, feel around you for something, anything to hold onto.");
            Thread.Sleep(500);
            lblal("Eventually through your searches you stumble upon the wall of this pitch black cave");
            Thread.Sleep(100);
            lblal("leaning agsinst it in relief you take this moment to rest up");
            Thread.Sleep(250);
            lblal("Continue Searching | Rest Abit", 0);
            string choice = PromptPlayer();
            if (string.Compare(choice, "Continue Searching", true) == 0)
            {
                continueSearching();
            }
            else if(string.Compare(choice, "Rest Abit", true) == 0)
            {
                restAbit();
            }
            else if (string.Compare(choice, "FIREBALL", true) == 0)
            {
                FIREBALL();
            }
            else
            {
                lblal("Yeah okay buddy. You have eyes dont you? See those two options that I went through the trouble of typing? Yeah? Use em");
                attemptToStand();
            }
        }
        static void continueSearching()
        {
            lblal("You just didn't listen to me huh? What did you think that would do?");
            Thread.Sleep(500);
            lblal("You'd just go boom I'm ready to move around again... No. You're screwed but sure I'll let you kill yourself...");
            Thread.Sleep(100);
            lblal("Attempting to find a way out or really anythng you decide to push once more. Forcing yourself off the wall");
            Thread.Sleep(500);
            lblal("Wobbling forward the blunt force of the exhaustion hits you. Your eyes roll backwards as your body shuts itself down.");
            Thread.Sleep(500);
            lblal("Falling head first into the harsh jagged stone floor, which then cracks your head open");
            Thread.Sleep(1500);
            lblal("GOOD JOB. You got ending #4 \"Passed tf out\" ending");
            string choice = PromptPlayer();
            if(string.Compare(choice, "Retry", true) == 0)
            {
                StartMenu();
            }
            else
            {
                lblal("Maybe you're that exhausted in real life you dont have the common sense to type in Retry. So here. I'll help");
                StartMenu();
            }
        }
        static void FIREBALL()
        {
            lblal("...");
            Thread.Sleep(1000);
            lblal("...");
            Thread.Sleep(1000);
            lblal("...What?");
            Thread.Sleep(500);
            lblal("Fireball? What are you a wizard? No dumbass you cant- ");
            Thread.Sleep(1000);
            lblal("Know what actually screw it you can.");
            Thread.Sleep(500);
            lblal("You muster up a sudden burst of energy to bring forth fire, illuminating the dank cave you reside in with firelight");
            Thread.Sleep(500);
            lblal("Forming this destructive force into a sphere you grow its density, it's power.");
            Thread.Sleep(500);
            lblal("Proceeding to launch it forth in hopes to break out of the cave");
            Thread.Sleep(1500);
            lblal("which doesn't work infact it blows you up, in a gruesome. Flaming death");
            Thread.Sleep(500);
            lblal("Con-fuckin-grats. You got the secret ending #3 \"Tried to be a Wizard\" ending");
            string choice = PromptPlayer();
            if (string.Compare(choice, "Retry", true) == 0)
            {
                StartMenu();
            }
            else
            {
                lblal("I cant even be bothered anymore, no insult just- Retry, here I'll do it for you... a fuckin Fireball, who even are you?");
                StartMenu();
            }
        }
        static void restAbit()
        {
            lblal("Taking in your newfound freedom, the utter exhaustion fully hits you as you crumple over against the wall.");
            Thread.Sleep(500);
            lblal("closing your eyes- Not that it matters. You cant see anything anyway... Trusting your body to wake up.");
            Thread.Sleep(500);
            lblal("Hoping it will... Just dont sleep for too long right? Or too short...");
            Thread.Sleep(500);
            lblal("Honestly how are you meant to tell how long it's been in a pitch black cave?");
            Thread.Sleep(100);
            lblal("Just guess I suppose, you'll be fine");
            Thread.Sleep(250);
            lblal("Sleep 1 | Sleep 2 | Sleep 3 | Sleep 4", 0);
            string choice = PromptPlayer();
            if(string.Compare(choice, "Sleep 1", true) == 0)
            {
                sleep1();
            }
            else if (string.Compare(choice, "Sleep 2", true) == 0)
            {
                sleep2();
            }
            else if (string.Compare(choice, "Sleep 3", true) == 0)
            {
                sleep3();
            }
            else if (string.Compare(choice, "Sleep 4", true) == 0)
            {
                sleep4();
            }
            else
            {
                lblal("You know, I am real tempted to just make you restart. How did you mess that up? Sleep 1-4 its utterly and painfully simple");
                restAbit();
            }
        }
        static void sleep1()
        {
            lblal("Sleep, ah sleep- What a wonderful thing, such restoration to your body caused by simply shutting your eyes.");
            Thread.Sleep(500);
            lblal("We all love sleep to some extent- You in particular seems to love sleep farrr more than the usual.");
            Thread.Sleep(500);
            lblal("Given you've slept for an entire 3 days, 3 days in an already starved and dehydrated body?");
            Thread.Sleep(500);
            lblal("yeah. A shame for you but this is the end of the line");
            Thread.Sleep(1500);
            lblal("GOOD On ya. got Ending #6 \"Starved in your sleep\" ending");
            string choice = PromptPlayer();
            if (string.Compare(choice, "Retry", true) == 0)
            {
                StartMenu();
            }
            else
            {
                lblal("Nope, that wasn't Retry now was it? here I'll help your dumb self.");
                StartMenu();
            }
        }
        static void sleep2()
        {
            lblal("Sleep, an activity you never pictured yourself doing ever again, yet here you are.");
            Thread.Sleep(500);
            lblal("Sleeping free- Annnd still sleeping...");
            Thread.Sleep(1000);
            lblal("OKay you can wake up now it's been long enough");
            Thread.Sleep(1000);
            lblal("you can uh- wake up?");
            Thread.Sleep(500);
            lblal("Welp looks like you picked the wrong option.. You didn't sleep at all. Infact you just died");
            Thread.Sleep(500);
            lblal("died of overworking yourself.");
            Thread.Sleep(100);
            lblal("Turns out all that activtiy for your starved self was far too much and your body offed itself the moment it had the chance to");
            Thread.Sleep(1000);
            lblal("Good Job you got ending #5. \"Died in your sleep\" ending, nice way to go compared to most of the endings");
            string choice = PromptPlayer();
            if(string.Compare(choice, "Retry", true) == 0)
            {
                StartMenu();
            }
            else
            {
                lblal("So uhhh, that wasn't Retry? Did you want to do something else or are you just that stupid, here. I'll do it for you");
                StartMenu();
            }
        }
        static void sleep3()
        {
            lblal("And a wonderful sleep it is, I'd say the perfect rest- A good full 10 hours of rest you just had");
            Thread.Sleep(500);
            lblal("tirring just moments later, you find yourself having sat down leaning against the wall.");
            Thread.Sleep(500);
            lblal("With all this newfound energy you shakily make your way to your feet. You have a few things to consider at this point");
            Thread.Sleep(250);
            lblal("1. You have to worry about your Hunger ");
            Thread.Sleep(250);
            lblal("2. You have to worry about your Thirst");
            Thread.Sleep(250);
            lblal("3. You have to worry about that very sentient and cognitive parasite that infected your body whilst you were sleeping");
            Thread.Sleep(100);
            lblal("and is now attempting to take it over, yes. That's right, have fun with that.");
            Thread.Sleep(1000);
            lblal("And that's where this adventure cuts off for now, maybe I'll expand the story later on in this class or take it home");
            Thread.Sleep(100);
            lblal("Either way you're done. Let's call this the good ending for now, so get on getting on");
            string choice = PromptPlayer();
            if (string.Compare(choice, "Retry", true) == 0)
            {
                StartMenu();
            }
            else
            {
                lblal("What? Too greedy to just type in Retry? Are you looking for something extra or did you mistype? either way I dont care");
                Thread.Sleep(250);
                lblal("What is going to happe now, is you close the game manually....");
                Thread.Sleep(2000);
                lblal("I'll wait....");
                Thread.Sleep(5000);
                lblal("Why are you still here? Leave");
                Thread.Sleep(5000);
                lblal("I need to do other things, screw off");
                Thread.Sleep(5000);
                lblal("Are you staying for the dialog? Is that it? Then fine. I'm done talking");
                Thread.Sleep(300000);
                lblal("Did you really just wait 5 minutes staring at a screen? Wow you have NO life. Know what? Wait another 5 and I'll show somthin");
                Thread.Sleep(300000);
                lblal("I changed my mind, wait another five. And I'll read your mind, ready?");
                Thread.Sleep(300000);
                lblal("You love femboys. Yeah. That's right. I know. Look at you, you just wasted so much time, go away, I'll restart it for you");
                StartMenu();
            }
        }
        static void sleep4()
        {
            lblal("Gee, I wonder why you haven't slept sooner than this. You could have avoided a good bit of trouble if you had just taken a nap");
            Thread.Sleep(500);
            lblal("though perhaps you dispise sleep given how short your nap just was- ");
            Thread.Sleep(500);
            lblal("Did you expect that to do anything to restore your energy? You slept at most 20 minutes.");
            Thread.Sleep(500);
            lblal("So silly of you- Ah well.");
            Thread.Sleep(250);
            lblal("You rest for your miniscule amount of time and fall flat on your face when you try to move. because you aren't at all energized.");
            Thread.Sleep(500);
            lblal("Good job player. You suck");
            Thread.Sleep(500);
            lblal("YIPPEE You got ending #7 \"You suck at sleeping\" ending");
            string choice = PromptPlayer();
            if (string.Compare(choice, "Retry", true) == 0)
            {
                StartMenu();
            }
            else
            {
                lblal("that, was not an option. Out of the one choice you had you managed to mess it up, how hard is it to type Retry?");
                StartMenu();
            }
        }



        static void takeABitToRest()
        {
            lblal("You decide it would be a good idea to shut your eyes for a moment. Rest... Gather your strength...");
            Thread.Sleep(1000);
            lblal(" What a fool you are- So overjoyed by your escape you failed to consider if you'd even wake up.");
            Thread.Sleep(500);
            lblal("you rest... rest. Continue to rest unable to wake- Slowly but surely the blood seeping from your nose floods the ground under you");
            Thread.Sleep(500);
            lblal("not alot but it is enough to cut off your oxygen... Unable to stand or move");
            Thread.Sleep(500);
            lblal("You drown. Drown in your own puddle of blood. A gruesome way to go isn't it?");
            Thread.Sleep(500);
            lblal("GOOOOD Job. Ending #3 \"You drowned in your own blood, Skill Issue\"");
            string choice = PromptPlayer();
            if(string.Compare(choice, "Retry", true) == 0)
            {
                StartMenu();
            }
            else
            {
                lblal("man I dont even know anymore, I cant be bothered to come up with an insult this time, go home. Get outta here");
                StartMenu();
            }
        }
       
        
        
        
        
        
        
        
        static void stayPut()
        {
            lblal("You bide your time. waiting amongst the darkness... Nothing happens as expected, what would come of inaction after all?");
            Thread.Sleep(1000);
            lblal("The fact you're down here is evidence enough no one cares to aid you. To even recall your existence... Though");
            Thread.Sleep(500);
            lblal("I cannot blame you. Waiting for death may just be the best thing you can do here, why continue to live in such a state?");
            Thread.Sleep(500);
            lblal("Surviving off of a few droplets of water falling from above your head, living in darkness.");
            Thread.Sleep(250);
            lblal("Unable to even walk around your cave- Unable to see how large your prison even is. Yes... Perhaps death would be a mercy");
            Thread.Sleep(250);
            lblal("Keep Staying | Struggle | Call Out", 0);
            string choice = PromptPlayer();
            if(string.Compare(choice, "Keep Staying", true) == 0)
            {
                keepStaying();
            }
            else if (string.Compare(choice, "Struggle", true) == 0)
            {
                Struggle();
            }
            else if (string.Compare(choice, "Call Out", true) == 0)
            {
                callOut();
            }
            else
            {
                lblal("And you failed to use one of the three options I gave you. What are you doing with your eyes? Putting them in the wash?");
                stayPut();
            }
        }
        static void keepStaying()
        {
            lblal("Darkness doesn't get any more pleasant");
            Thread.Sleep(500);
            lblal("the steady pattering of water droplets hitting the stone infront of you proves to become irritating rather than calming.");
            Thread.Sleep(500);
            lblal("You want to move... wish to get up. Exit this cave- Liberate yourself...Blah blah blah");
            Thread.Sleep(500);
            lblal("But that isn't what you get.");
            Thread.Sleep(100);
            lblal("is it?");
            Thread.Sleep(500);
            lblal("No you dont get to leave, get to stand and run. get to see light you dont get to escape that infernal sound.");
            Thread.Sleep(200);
            lblal("No... You get to stay in this cave until your body runs out of fat to feed itself on.");
            Thread.Sleep(200);
            lblal("Runs out of muscle to burn... Death comes slow for you, what you did do to deserve it?");
            Thread.Sleep(200);
            lblal("..if you even deserve it, none of that matters at this point. Does it?");
            Thread.Sleep(200);
            lblal("Stay a Bit Longer | Struggle | Call Out", 0);
            string choice = PromptPlayer();
            if (string.Compare(choice, "Stay a Bit Longer", true) == 0)
            {
                stayABitLonger();
            }
            else if (string.Compare(choice, "Struggle", true) == 0)
            {
                Struggle();
            }
            else if (string.Compare(choice, "Call Out", true) == 0)
            {
                callOut();
            }
            else
            {
                lblal("Oookay good effort maybe use your eyes this time and capatilize what you need to, or just yknow pick one of the options");
            }


        }
        static void stayABitLonger()
        {
            lblal("And that's just what you do, stay put....");
            Thread.Sleep(1000);
            lblal("Sitting still is all your good for anymore isn't it?");
            Thread.Sleep(100);
            lblal("As your body consumes itself. The few nutrients it had run out");
            Thread.Sleep(500);
            lblal("the water above so close yet you haven't the strength to even lean your head forward and drink it.");
            Thread.Sleep(500);
            lblal("You sit");
            Thread.Sleep(500);
            lblal("....and sit");
            Thread.Sleep(500);
            lblal("And slowly but surely you die... Die alone in a dark cave. With nothing to show for it");
            Thread.Sleep(500);
            lblal("No loved ones to see you off, no one to honor your death.");
            Thread.Sleep(500);
            lblal("Not even a soul around- You aren't even worth the pity of an insect.");
            Thread.Sleep(1500);
            lblal("CONGRATS You got ending #1 \"Died alone in a cave\" GOOD Job sitting still like that");
            Thread.Sleep(50);
            lblal("I know it was so hard typing in three prompts instead of just doing something more interesting.Annyway retry ?");
            string choice = PromptPlayer();
            if (string.Compare(choice, "Retry", true) == 0)
            {
                StartMenu();
            }
            else if (string.Compare(choice, "STAY PUT", true) == 0)
            {
                STAYPUT();
            }
            else
            {
                lblal("What? Did you want something else? No. F you, get better at typing, use your brain and type the right thing in you dumb-");
                StartMenu();
            }
        }
        static void STAYPUT()
        {
            lblal("Oh very funny aren't you. What are you conditioned to sitting still? kay fine here.");
            Thread.Sleep(250);
            lblal("You sit still some more and end up extra dead- Congrats.");
            Thread.Sleep(250);
            lblal("Your dead body didn't move and rotted, decomposed. You happy? happy with yourself?");
            Thread.Sleep(250);
            lblal("Have the Decomposed Ending. You're Welcome. Secret Ending #1");
            string choice = PromptPlayer();
            if(string.Compare(choice, "Retry", true)==0)
            {
                StartMenu();
            }
            else
            {
                lblal("what? Did you expect more? Fuckin dumbass. You got the secret ending boom done deal with it, go home");
                StartMenu();
            }
        }

        static void helloDerek() //GIVE ME MONEY
        {

            lblal("Hello Derek, how are you? Is this working? Hope it is");
            string[] plz = { "Working?", "no? Yes?", "It would be so awesome", "it would be so cool" };
            for (int i = 0; i < plz.Length; i++)
            {
                Console.WriteLine(plz[i]);

            }
        }
    }

}

