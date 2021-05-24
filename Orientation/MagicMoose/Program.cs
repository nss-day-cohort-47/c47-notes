using System;
using System.Collections.Generic;

Main();

void Main()
{
    while (true)
    {
        string question = PromptForQuestion();
        if (string.IsNullOrWhiteSpace(question))
        {
            Console.WriteLine("Good-bye");
            return;
        }

        int answerCount = 20;
        int number = new Random().Next(answerCount);

        string answer = GetAnswerUsingIf(number);
        //string answer = GetAnswerUsingSwitch(number);
        //string answer = GetAnswerUsingList(number);

        MooseSays(answer);
        Console.Write("Press enter to continue...");
        Console.ReadLine();
        Console.Clear();
    }
}

string PromptForQuestion()
{
    MooseSays("Ask me your question and be amazed!");
    Console.Write("> ");
    return Console.ReadLine();
}

string GetAnswerUsingIf(int number)
{
    if (number == 0)
    {
        return "As I see it, yes.";
    }
    if (number == 1)
    {
        return "Ask again later.";
    }
    if (number == 2)
    {
        return "Better not tell you now.";
    }
    if (number == 3)
    {
        return "Cannot predict now.";
    }
    if (number == 4)
    {
        return "Concentrate and ask again.";
    }
    if (number == 5)
    {
        return "Don’t count on it.";
    }
    if (number == 6)
    {
        return "It is certain.";
    }
    if (number == 7)
    {
        return "It is decidedly so.";
    }
    if (number == 8)
    {
        return "Most likely.";
    }
    if (number == 9)
    {
        return "My reply is no.";
    }
    if (number == 10)
    {
        return "My sources say no.";
    }
    if (number == 11)
    {
        return "Outlook not so good.";
    }
    if (number == 12)
    {
        return "Outlook good.";
    }
    if (number == 13)
    {
        return "Reply hazy, try again.";
    }
    if (number == 14)
    {
        return "Signs point to yes.";
    }
    if (number == 15)
    {
        return "Very doubtful.";
    }
    if (number == 16)
    {
        return "Without a doubt.";
    }
    if (number == 17)
    {
        return "Yes.";
    }
    if (number == 18)
    {
        return "Yes – definitely.";
    }
    if (number == 19)
    {
        return "You may rely on it.";
    }
    return "I don't know what you're talking about.";
}

string GetAnswerUsingSwitch(int number)
{
    switch (number)
    {
        case 0: return "As I see it, yes.";
        case 1: return "Ask again later.";
        case 2: return "Better not tell you now.";
        case 3: return "Cannot predict now.";
        case 4: return "Concentrate and ask again.";
        case 5: return "Don’t count on it.";
        case 6: return "It is certain.";
        case 7: return "It is decidedly so.";
        case 8: return "Most likely.";
        case 9: return "My reply is no.";
        case 10: return "My sources say no.";
        case 11: return "Outlook not so good.";
        case 12: return "Outlook good.";
        case 13: return "Reply hazy, try again.";
        case 14: return "Signs point to yes.";
        case 15: return "Very doubtful.";
        case 16: return "Without a doubt.";
        case 17: return "Yes.";
        case 18: return "Yes – definitely.";
        case 19: return "You may rely on it.";
        default: return "I don't know what you're talking about.";
    }
}

string GetAnswerUsingList(int number)
{
    List<string> answerChoices = new List<string>() {
        "As I see it, yes.", "Ask again later.", "Better not tell you now.",
        "Cannot predict now.", "Concentrate and ask again.", "Don’t count on it.",
        "It is certain.", "It is decidedly so.", "Most likely.",
        "My reply is no.", "My sources say no.", "Outlook not so good.",
        "Outlook good.", "Reply hazy, try again.", "Signs point to yes.",
        "Very doubtful.", "Without a doubt.", "Yes.",
        "Yes – definitely.", "You may rely on it.",
    };

    if (number < 0 || number >= answerChoices.Count)
    {
        return "I don't know what you're talking about.";
    }

    return answerChoices[number];
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}