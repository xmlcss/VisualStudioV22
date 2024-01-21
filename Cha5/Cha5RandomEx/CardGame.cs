//CardGame.cs--牌类游戏（CardGame）的设计与实现
//需求描述：模拟网上的牌类游戏，完成牌类游戏的创建牌、洗牌和发牌功能。
//知识点：类库-随机数
using System;
#nullable disable
namespace Cha5RandomEx
{
    //牌类
    class Card
    {
        private string face;
        private string suit;

        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }
        public override string ToString()
        {
            return face + " of " + suit;
        }
    }

    //牌类操作
    class DeckOfCards
    {
        private Card[] deck;//一副牌
        private int currentCard;
        private const int NUMBER_OF_CARDS = 52;
        private Random randomNumbers;

        //构造函数初始化一副牌
        public DeckOfCards()
        {
            string[] faces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            deck = new Card[NUMBER_OF_CARDS];
            currentCard = 0;
            //  randomNumbers = new Random();

            for (int count = 0; count < deck.Length; ++count)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }
        }

        //洗牌，打乱次序
        public void Shuffle()
        {
            randomNumbers = new Random();
            currentCard = 0;
            for (int first = 0; first < deck.Length; ++first)
            {
                int second = randomNumbers.Next(NUMBER_OF_CARDS);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        //发牌
        public Card DealCard()
        {
            if (currentCard < deck.Length)
                return deck[currentCard++];
            else
                return null;
        }
    }

    //调用
    public class Test
    {
        static void Main(string[] args)
        {
            DeckOfCards myDd = new DeckOfCards();
            myDd.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Console.Write("{0,-16}", myDd.DealCard());
                if ((i + 1) % 4 == 0)
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
