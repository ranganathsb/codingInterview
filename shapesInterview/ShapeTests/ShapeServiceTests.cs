﻿using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using shapes;

namespace ShapeTests
{
    [TestFixture]
    public class ShapeServiceTests
    {
        [Test]
        public void CalculateTotalPerimeterShouldReturnTotal()
        {
            const int shapeOnePerimeter = 4;
            const int shapeTwoPerimeter = 8;
            const int shapeThreePerimeter = 12;

            IList<IShape> shapes = new List<IShape>();
            //add shapes, do not reference square within this file, use a mocking framework


            //call method 
            double totalParimeter = 0d;

            //assert result
            totalParimeter.Should().Be(shapeOnePerimeter + shapeTwoPerimeter + shapeThreePerimeter);
        }
    }
}