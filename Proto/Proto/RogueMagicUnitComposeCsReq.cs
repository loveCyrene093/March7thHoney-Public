using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueMagicUnitComposeCsReq : IMessage<RogueMagicUnitComposeCsReq>, IMessage, IEquatable<RogueMagicUnitComposeCsReq>, IDeepCloneable<RogueMagicUnitComposeCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueMagicUnitComposeCsReq> _parser = new MessageParser<RogueMagicUnitComposeCsReq>(() => new RogueMagicUnitComposeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IGEABMFLCGCFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_iGEABMFLCGC_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> iGEABMFLCGC_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueMagicUnitComposeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueMagicUnitComposeCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IGEABMFLCGC => iGEABMFLCGC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicUnitComposeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicUnitComposeCsReq(RogueMagicUnitComposeCsReq other)
		: this()
	{
		iGEABMFLCGC_ = other.iGEABMFLCGC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicUnitComposeCsReq Clone()
	{
		return new RogueMagicUnitComposeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueMagicUnitComposeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueMagicUnitComposeCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iGEABMFLCGC_.Equals(other.iGEABMFLCGC_))
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
		num ^= iGEABMFLCGC_.GetHashCode();
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
		iGEABMFLCGC_.WriteTo(ref output, _repeated_iGEABMFLCGC_codec);
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
		num += iGEABMFLCGC_.CalculateSize(_repeated_iGEABMFLCGC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueMagicUnitComposeCsReq other)
	{
		if (other != null)
		{
			iGEABMFLCGC_.Add(other.iGEABMFLCGC_);
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
			if (num != 56 && num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				iGEABMFLCGC_.AddEntriesFrom(ref input, _repeated_iGEABMFLCGC_codec);
			}
		}
	}
}
