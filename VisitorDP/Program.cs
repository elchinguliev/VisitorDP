using VisitorDP;

var emailVisitor=new EmailVisitor();
var textVisitor=new TextVisitor();  
var webSocketVisitor=new WebSocketVisitor();

var notificationSende1=new InVoiceNotificationSender();
notificationSende1.Accept(emailVisitor);
notificationSende1.Accept(textVisitor);
notificationSende1.Send("Invoice");

var notificationSende2 = new MarketingNotificationCenter();
notificationSende2.Accept(emailVisitor);
notificationSende2.Accept(textVisitor);
notificationSende2.Accept(webSocketVisitor);
notificationSende2.Send("Marketing");