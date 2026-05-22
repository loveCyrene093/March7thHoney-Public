using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFriendRecommendLineupCsReq : IMessage<GetFriendRecommendLineupCsReq>, IMessage, IEquatable<GetFriendRecommendLineupCsReq>, IDeepCloneable<GetFriendRecommendLineupCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetFriendRecommendLineupCsReq> _parser = new MessageParser<GetFriendRecommendLineupCsReq>(() => new GetFriendRecommendLineupCsReq());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 2;

	private NFKEJJIHOCJ type_;

	public const int KeyFieldNumber = 10;

	private uint key_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFriendRecommendLineupCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFriendRecommendLineupCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NFKEJJIHOCJ Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Key
	{
		get
		{
			return key_;
		}
		set
		{
			key_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendRecommendLineupCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendRecommendLineupCsReq(GetFriendRecommendLineupCsReq other)
		: this()
	{
		type_ = other.type_;
		key_ = other.key_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendRecommendLineupCsReq Clone()
	{
		return new GetFriendRecommendLineupCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFriendRecommendLineupCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFriendRecommendLineupCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Key != other.Key)
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
		if (Type != NFKEJJIHOCJ.Pcpdhelpkem)
		{
			num ^= Type.GetHashCode();
		}
		if (Key != 0)
		{
			num ^= Key.GetHashCode();
		}
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
		if (Type != NFKEJJIHOCJ.Pcpdhelpkem)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Type);
		}
		if (Key != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Key);
		}
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
		if (Type != NFKEJJIHOCJ.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Key != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Key);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFriendRecommendLineupCsReq other)
	{
		if (other != null)
		{
			if (other.Type != NFKEJJIHOCJ.Pcpdhelpkem)
			{
				Type = other.Type;
			}
			if (other.Key != 0)
			{
				Key = other.Key;
			}
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
			case 16u:
				Type = (NFKEJJIHOCJ)input.ReadEnum();
				break;
			case 80u:
				Key = input.ReadUInt32();
				break;
			}
		}
	}
}
