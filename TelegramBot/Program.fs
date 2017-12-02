namespace SimpleTelebot

open Telegram.Bot;
module Telebot =

    let receiveError a =        
        0 |> ignore;

    let inLineResult a =
        0 |> ignore;

    let inLineQuery a =
        0 |> ignore;
    
    let messageReceived a =
        0 |> ignore;

    let callbackQuery a = 
        0 |> ignore;


    [<EntryPoint>]
    let main argv = 
        let bot = new TelegramBotClient("API KEY");
        bot.OnCallbackQuery.Add(callbackQuery);
        bot.OnMessage.Add(messageReceived);
        bot.OnInlineQuery.Add(inLineQuery);
        bot.OnInlineResultChosen.Add(inLineResult);
        bot.OnReceiveError.Add(receiveError);
        bot.OnMessageEdited.Add(messageReceived);
        0

