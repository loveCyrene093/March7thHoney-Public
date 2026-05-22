using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContentPackageData : IMessage<ContentPackageData>, IMessage, IEquatable<ContentPackageData>, IDeepCloneable<ContentPackageData>, IBufferMessage
{
	private static readonly MessageParser<ContentPackageData> _parser = new MessageParser<ContentPackageData>(() => new ContentPackageData());

	private UnknownFieldSet _unknownFields;

	public const int CurContentIdFieldNumber = 13;

	private uint curContentId_;

	public const int ContentPackageListFieldNumber = 14;

	private static readonly FieldCodec<ContentPackageInfo> _repeated_contentPackageList_codec = FieldCodec.ForMessage(114u, ContentPackageInfo.Parser);

	private readonly RepeatedField<ContentPackageInfo> contentPackageList_ = new RepeatedField<ContentPackageInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ContentPackageData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ContentPackageDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurContentId
	{
		get
		{
			return curContentId_;
		}
		set
		{
			curContentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ContentPackageInfo> ContentPackageList => contentPackageList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContentPackageData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContentPackageData(ContentPackageData other)
		: this()
	{
		curContentId_ = other.curContentId_;
		contentPackageList_ = other.contentPackageList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContentPackageData Clone()
	{
		return new ContentPackageData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ContentPackageData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContentPackageData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CurContentId != other.CurContentId)
		{
			return false;
		}
		if (!contentPackageList_.Equals(other.contentPackageList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (CurContentId != 0)
		{
			num ^= CurContentId.GetHashCode();
		}
		num ^= contentPackageList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (CurContentId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(CurContentId);
		}
		contentPackageList_.WriteTo(ref output, _repeated_contentPackageList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (CurContentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurContentId);
		}
		num += contentPackageList_.CalculateSize(_repeated_contentPackageList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContentPackageData other)
	{
		if (other != null)
		{
			if (other.CurContentId != 0)
			{
				CurContentId = other.CurContentId;
			}
			contentPackageList_.Add(other.contentPackageList_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 104u:
				CurContentId = input.ReadUInt32();
				break;
			case 114u:
				contentPackageList_.AddEntriesFrom(ref input, _repeated_contentPackageList_codec);
				break;
			}
		}
	}
}
