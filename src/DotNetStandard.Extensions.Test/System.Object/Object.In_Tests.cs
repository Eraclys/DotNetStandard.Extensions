﻿using System;
using FluentAssertions;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class ObjectExtensions_In_Tests
    {
        [Test]
        public void WhenObjectIsInCollection_ReturnTrue()
        {
            "b".In("a","b", "c").Should().BeTrue();
            5.In(5, 6, 9, -1).Should().BeTrue();
            "b".In(StringComparer.OrdinalIgnoreCase, "a", "B", "c").Should().BeTrue();
        }

        [Test]
        public void WhenObjectIsNotInCollection_ReturnFalse()
        {
            "b".In("a", "c").Should().BeFalse();
            5.In(6, 9, -1).Should().BeFalse();
            "b".In(StringComparer.OrdinalIgnoreCase, "a", "c").Should().BeFalse();
        }
    }
}
