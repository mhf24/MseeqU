using Bdeir.Quizzer.Core;
using System.Linq;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Bdeir.Quizzer.Bots
{
    public class TelegramBot
    {
        ITelegramBotClient botClient;
        string botChannelId;
        public TelegramBot(string botToken, string botChannelId)
        {
            botClient = new TelegramBotClient(botToken);
            this.botChannelId = botChannelId;
            
        }
        public Message SendQuestion(IQuestion q)
        {
            return botClient.SendPollAsync(
                 chatId         : this.botChannelId
                ,type           : Telegram.Bot.Types.Enums.PollType.Quiz
                ,question       : q.Prompt
                ,options        : q.ShuffledAnswers.Select(p => p.AnswerText)
                ,correctOptionId: q.ShuffledAnswers.FindIndex(p => p.Correct)
            ).Result;
        }
    }
}