using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetBigDataAllRecommendCsReq : IMessage<GetBigDataAllRecommendCsReq>, IMessage, IEquatable<GetBigDataAllRecommendCsReq>, IDeepCloneable<GetBigDataAllRecommendCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetBigDataAllRecommendCsReq> _parser = new MessageParser<GetBigDataAllRecommendCsReq>(() => new GetBigDataAllRecommendCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BigDataRecommendTypeFieldNumber = 1;

	private BigDataRecommendType bigDataRecommendType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetBigDataAllRecommendCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetBigDataAllRecommendCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BigDataRecommendType BigDataRecommendType
	{
		get
		{
			return bigDataRecommendType_;
		}
		set
		{
			bigDataRecommendType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBigDataAllRecommendCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBigDataAllRecommendCsReq(GetBigDataAllRecommendCsReq other)
		: this()
	{
		bigDataRecommendType_ = other.bigDataRecommendType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBigDataAllRecommendCsReq Clone()
	{
		return new GetBigDataAllRecommendCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetBigDataAllRecommendCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetBigDataAllRecommendCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BigDataRecommendType != other.BigDataRecommendType)
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
		if (BigDataRecommendType != BigDataRecommendType.None)
		{
			num ^= BigDataRecommendType.GetHashCode();
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
		if (BigDataRecommendType != BigDataRecommendType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)BigDataRecommendType);
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
		if (BigDataRecommendType != BigDataRecommendType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BigDataRecommendType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetBigDataAllRecommendCsReq other)
	{
		if (other != null)
		{
			if (other.BigDataRecommendType != BigDataRecommendType.None)
			{
				BigDataRecommendType = other.BigDataRecommendType;
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				BigDataRecommendType = (BigDataRecommendType)input.ReadEnum();
			}
		}
	}
}
