using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFantasticStoryActivityDataCsReq : IMessage<GetFantasticStoryActivityDataCsReq>, IMessage, IEquatable<GetFantasticStoryActivityDataCsReq>, IDeepCloneable<GetFantasticStoryActivityDataCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetFantasticStoryActivityDataCsReq> _parser = new MessageParser<GetFantasticStoryActivityDataCsReq>(() => new GetFantasticStoryActivityDataCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CEIMNDJFDJDFieldNumber = 4;

	private uint cEIMNDJFDJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFantasticStoryActivityDataCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFantasticStoryActivityDataCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CEIMNDJFDJD
	{
		get
		{
			return cEIMNDJFDJD_;
		}
		set
		{
			cEIMNDJFDJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFantasticStoryActivityDataCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFantasticStoryActivityDataCsReq(GetFantasticStoryActivityDataCsReq other)
		: this()
	{
		cEIMNDJFDJD_ = other.cEIMNDJFDJD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFantasticStoryActivityDataCsReq Clone()
	{
		return new GetFantasticStoryActivityDataCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFantasticStoryActivityDataCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFantasticStoryActivityDataCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CEIMNDJFDJD != other.CEIMNDJFDJD)
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
		if (CEIMNDJFDJD != 0)
		{
			num ^= CEIMNDJFDJD.GetHashCode();
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
		if (CEIMNDJFDJD != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CEIMNDJFDJD);
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
		if (CEIMNDJFDJD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CEIMNDJFDJD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFantasticStoryActivityDataCsReq other)
	{
		if (other != null)
		{
			if (other.CEIMNDJFDJD != 0)
			{
				CEIMNDJFDJD = other.CEIMNDJFDJD;
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
			if (num != 32)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				CEIMNDJFDJD = input.ReadUInt32();
			}
		}
	}
}
