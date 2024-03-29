﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
        // John is from USA, So he can speak and understand only English
        public class AmericanPerson : IEnglishSpeaker
        {
            public string AskQuestion(string Words)
            {
                Console.WriteLine("Question Asked by John [English Speaker and Can understand only English] : " + Words);
                ITarget target = new Adapter();
                string replyFromDavid = target.TranslateAndTellToOtherPerson(Words, "French");
                return replyFromDavid;
            }

            public string AnswerFortheQuestion(string Words)
            {
                string reply = null;
                if (Words.Equals("where are you?", StringComparison.InvariantCultureIgnoreCase))
                {
                    reply = "I am in USA";
                }
                return reply;
            }
    }
}
