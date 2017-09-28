using NUnit.Framework;

namespace FizzleBizzle
{
    [TestFixture]
    public class FizzleBizzleTests
    {
        private Models.FizzleBizzle _fizzleBizzle;

        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void _01_Initializing_FizzleBizzle_with_Fizz_equal_to_5_and_Buzz_equal_to_10()
        {
            _fizzleBizzle = new Models.FizzleBizzle(5, 10);

            Assert.That(_fizzleBizzle.Fizz, Is.EqualTo(5));
            Assert.That(_fizzleBizzle.Buzz, Is.EqualTo(10));
        }

        [Test]
        public void _02_A_FizzleBizzle_array_from_1_to_10_has_a_length_of_10()
        {
            _fizzleBizzle = new Models.FizzleBizzle(5, 10);
            var array = _fizzleBizzle.FizzBuzz(1, 10);

            Assert.That(array.Length, Is.EqualTo(10));
        }

        [Test]
        public void _03_A_Fizz_equal_to_7_and_a_Buzz_equal_to_9_should_have_a_Fizz_at_7_and_a_Buzz_at_9()
        {
            _fizzleBizzle = new Models.FizzleBizzle(7, 9);
            var array = _fizzleBizzle.FizzBuzz(1, 10);

            Assert.That(array[6], Is.EqualTo("Fizz"));
            Assert.That(array[8], Is.EqualTo("Buzz"));
        }

        [Test]
        public void _04_A_Fizz_equal_to_2_and_a_Buzz_equal_to_3_should_have_a_FizzBuzz_at_6()
        {
            _fizzleBizzle = new Models.FizzleBizzle(2, 3);
            var array = _fizzleBizzle.FizzBuzz(0, 10);

            Assert.That(array[6], Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void _05_A_Fizz_equal_to_7_and_a_Buzz_equal_to_53_should_have_a_FizzBuzz_at_0()
        {
            _fizzleBizzle = new Models.FizzleBizzle(7, 53);
            var array = _fizzleBizzle.FizzBuzz(0, 10);

            Assert.That(array[0], Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void _06_A_Fizz_equal_to_minus_5_and_a_Buzz_equal_to_6_should_have_a_Fizz_at_10_and_a_Buzz_at_minus_12()
        {
            _fizzleBizzle = new Models.FizzleBizzle(-5, 6);
            var array = _fizzleBizzle.FizzBuzz(-13, 11);

            Assert.That(array[1], Is.EqualTo("Buzz"));
            Assert.That(array[23], Is.EqualTo("Fizz"));
        }

        [Test]
        public void _07_A_start_number_less_than_an_end_number_should_increase_through_the_array()
        {
            _fizzleBizzle = new Models.FizzleBizzle(7, 9);
            var array = _fizzleBizzle.FizzBuzz(1, 11);

            Assert.That(int.Parse(array[0]) < int.Parse(array[5]));
        }

        [Test]
        public void _08_A_start_number_greater_than_an_end_number_should_decrease_through_the_array()
        {
            _fizzleBizzle = new Models.FizzleBizzle(7, 9);
            var array = _fizzleBizzle.FizzBuzz(11, 1);

            Assert.That(int.Parse(array[0]) > int.Parse(array[5]));
        }

        [Test]
        public void _09_A_start_number_equal_to_an_end_number_should_have_a_length_of_1_and_equal_that_number()
        {
            _fizzleBizzle = new Models.FizzleBizzle(7, 9);
            var array = _fizzleBizzle.FizzBuzz(5, 5);

            Assert.That(array.Length, Is.EqualTo(1));
            Assert.That(int.Parse(array[0]), Is.EqualTo(5));
        }

        [Test]
        public void _10_A_1_Fizz_adds_Fizz_to_every_number()
        {
            _fizzleBizzle = new Models.FizzleBizzle(1, 2);
            var array = _fizzleBizzle.FizzBuzz(0, 50);

            Assert.That(array[3], Is.EqualTo("Fizz"));
            Assert.That(array[23], Is.EqualTo("Fizz"));
            Assert.That(array[33], Is.EqualTo("Fizz"));
            Assert.That(array[49], Is.EqualTo("Fizz"));
        }

        [Test]
        public void _11_A_FizzleBuzzBazz_array_from_1_to_10_has_a_length_of_10()
        {
            _fizzleBizzle = new Models.FizzleBizzle(5, 10);
            var array = _fizzleBizzle.FizzBuzzBazz(1, 10, delegate (int a) { return false; });

            Assert.That(array.Length, Is.EqualTo(10));
        }

        [Test]
        public void _12_A_Fizz_equal_to_3_and_a_Buzz_equal_to_4_and_a_bazz_greater_than_5_should_have_a_FizzBuzzBazz_at_12()
        {
            _fizzleBizzle = new Models.FizzleBizzle(3, 4);
            var array = _fizzleBizzle.FizzBuzzBazz(0, 15, delegate (int a) { return a > 5; });

            Assert.That(array[12], Is.EqualTo("FizzBuzzBazz"));
        }

        [Test]
        public void _13_A_Fizz_equal_to_3_and_a_Buzz_equal_to_4_and_a_bazz_less_than_5_should_have_a_FizzBuzzBazz_at_0()
        {
            _fizzleBizzle = new Models.FizzleBizzle(3, 4);
            var array = _fizzleBizzle.FizzBuzzBazz(0, 10, delegate (int a) { return a < 5; });

            Assert.That(array[0], Is.EqualTo("FizzBuzzBazz"));
        }

        [Test]
        public void _14_A_Fizz_equal_to_3_and_a_Buzz_equal_to_5_and_a_bazz_equal_to_15_should_have_a_FizzBuzzBazz_at_15()
        {
            _fizzleBizzle = new Models.FizzleBizzle(3, 5);
            var array = _fizzleBizzle.FizzBuzzBazz(0, 16, delegate (int a) { return a == 15; });

            Assert.That(array[15], Is.EqualTo("FizzBuzzBazz"));
        }

        [Test]
        public void _15_A_Fizz_equal_to_4_and_a_Buzz_equal_to_4_and_a_bazz_greater_than_or_equal_to_15_should_have_a_FizzBuzzBazz_at_16()
        {
            _fizzleBizzle = new Models.FizzleBizzle(4, 4);
            var array = _fizzleBizzle.FizzBuzzBazz(0, 16, delegate (int a) { return a >= 15; });

            Assert.That(array[16], Is.EqualTo("FizzBuzzBazz"));
        }

        [Test]
        public void _16_A_Fizz_equal_to_2_and_a_Buzz_equal_to_5_and_a_bazz_less_than_or_equal_to_15_should_have_a_FizzBuzzBazz_at_10()
        {
            _fizzleBizzle = new Models.FizzleBizzle(2, 5);
            var array = _fizzleBizzle.FizzBuzzBazz(0, 16, delegate (int a) { return a <= 15; });

            Assert.That(array[10], Is.EqualTo("FizzBuzzBazz"));
        }

        [Test]
        public void _17_A_Fizz_equal_to_2_and_a_Buzz_equal_to_5_and_a_bazz_not_equal_to_15_should_have_a_FizzBuzzBazz_at_10()
        {
            _fizzleBizzle = new Models.FizzleBizzle(2, 5);
            var array = _fizzleBizzle.FizzBuzzBazz(0, 16, delegate (int a) { return a != 15; });

            Assert.That(array[10], Is.EqualTo("FizzBuzzBazz"));
        }

        [Test]
        public void _18_A_start_number_less_than_an_end_number_should_increase_through_the_array()
        {
            _fizzleBizzle = new Models.FizzleBizzle(7, 9);
            var array = _fizzleBizzle.FizzBuzzBazz(1, 11, delegate (int a) { return false; });

            Assert.That(int.Parse(array[0]) < int.Parse(array[5]));
        }

        [Test]
        public void _19_A_start_number_greater_than_an_end_number_should_decrease_through_the_array()
        {
            _fizzleBizzle = new Models.FizzleBizzle(7, 9);
            var array = _fizzleBizzle.FizzBuzzBazz(11, 1, delegate (int a) { return false; });

            Assert.That(int.Parse(array[0]) > int.Parse(array[5]));
        }

        [Test]
        public void _20_A_start_number_equal_to_an_end_number_should_have_a_length_of_1_and_equal_that_number()
        {
            _fizzleBizzle = new Models.FizzleBizzle(7, 9);
            var array = _fizzleBizzle.FizzBuzzBazz(5, 5, delegate (int a) { return false; });

            Assert.That(array.Length, Is.EqualTo(1));
            Assert.That(int.Parse(array[0]), Is.EqualTo(5));

        }


    }
}