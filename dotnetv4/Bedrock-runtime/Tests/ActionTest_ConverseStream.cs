﻿// Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved. 
// SPDX-License-Identifier: Apache-2.0

namespace BedrockRuntimeTests;

public class ActionTest_ConverseStream
{
    [Theory, Trait("Category", "Integration")]
    [InlineData(typeof(AmazonTitanText.ConverseStream))]
    [InlineData(typeof(Mistral.ConverseStream))]
    [InlineData(typeof(MetaLlama.ConverseStream))]
    [InlineData(typeof(CohereCommand.ConverseStream))]
    [InlineData(typeof(AnthropicClaude.ConverseStream))]
    public void ConverseStreamDoesNotThrow(Type type)
    {
        Thread.Sleep(5000);
        var entryPoint = type.Assembly.EntryPoint!;
        var exception = Record.Exception(() => entryPoint.Invoke(null, [Array.Empty<string>()]));
        Assert.Null(exception);
    }
}