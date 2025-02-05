﻿// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at https://mozilla.org/MPL/2.0/.

using ActivityPub.Types.Collection;
using ActivityPub.Types.Extended.Activity;
using ActivityPub.Types.Extended.Actor;
using ActivityPub.Types.Extended.Link;
using ActivityPub.Types.Extended.Object;
using ActivityPub.Types.Tests.Util.Fixtures;

namespace ActivityPub.Types.Tests.Smoke.Samples.Firefish;

public class FirefishSampleTests : SampleTests
{
    public FirefishSampleTests(JsonLdSerializerFixture fixture) : base(fixture) {}

    [Fact]
    public void CreateShouldConvert() => TestSample(typeof(CreateActivity), CreateActivity.CreateType);

    [Fact]
    public void HashtagShouldConvert() => TestSample(typeof(ASObject), "Hashtag");
    
    [Fact]
    public void ImageShouldConvert() => TestSample(typeof(ImageObject), ImageObject.ImageType);
    
    [Fact]
    public void KeyShouldConvert() => TestSample(typeof(ASObject), "Key");
    
    [Fact]
    public void MentionShouldConvert() => TestSample(typeof(MentionLink), MentionLink.MentionType);

    [Fact]
    public void NoteShouldConvert() => TestSample(typeof(NoteObject), NoteObject.NoteType);

    [Fact]
    public void ObjectShouldConvert() => TestSample(typeof(ASObject), ASObject.ObjectType);

    [Fact]
    public void OrderedCollectionShouldConvert() => TestSample(typeof(ASOrderedCollection<ASObject>), CollectionTypes.OrderedCollectionType);

    [Fact]
    public void OrderedCollectionPageShouldConvert() => TestSample(typeof(ASOrderedCollectionPage<ASObject>), CollectionTypes.OrderedCollectionPageType);
    
    [Fact]
    public void PersonActorShouldConvert() => TestSample(typeof(PersonActor), PersonActor.PersonType);

    [Fact]
    public void PropertyValueShouldConvert() => TestSample(typeof(ASObject), "PropertyValue");
}