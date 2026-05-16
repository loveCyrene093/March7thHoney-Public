using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PECMFBCBLHH : IMessage<PECMFBCBLHH>, IMessage, IEquatable<PECMFBCBLHH>, IDeepCloneable<PECMFBCBLHH>, IBufferMessage
{
	private static readonly MessageParser<PECMFBCBLHH> _parser = new MessageParser<PECMFBCBLHH>(() => new PECMFBCBLHH());

	private UnknownFieldSet _unknownFields;

	public const int HLCOMGHMLEPFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_hLCOMGHMLEP_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> hLCOMGHMLEP_ = new RepeatedField<uint>();

	public const int StageIdFieldNumber = 13;

	private uint stageId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PECMFBCBLHH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PECMFBCBLHHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HLCOMGHMLEP => hLCOMGHMLEP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PECMFBCBLHH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PECMFBCBLHH(PECMFBCBLHH other)
		: this()
	{
		hLCOMGHMLEP_ = other.hLCOMGHMLEP_.Clone();
		stageId_ = other.stageId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PECMFBCBLHH Clone()
	{
		return new PECMFBCBLHH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PECMFBCBLHH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PECMFBCBLHH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hLCOMGHMLEP_.Equals(other.hLCOMGHMLEP_))
		{
			return false;
		}
		if (StageId != other.StageId)
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
		num ^= hLCOMGHMLEP_.GetHashCode();
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
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
		hLCOMGHMLEP_.WriteTo(ref output, _repeated_hLCOMGHMLEP_codec);
		if (StageId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(StageId);
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
		num += hLCOMGHMLEP_.CalculateSize(_repeated_hLCOMGHMLEP_codec);
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PECMFBCBLHH other)
	{
		if (other != null)
		{
			hLCOMGHMLEP_.Add(other.hLCOMGHMLEP_);
			if (other.StageId != 0)
			{
				StageId = other.StageId;
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
			case 18u:
				hLCOMGHMLEP_.AddEntriesFrom(ref input, _repeated_hLCOMGHMLEP_codec);
				break;
			case 104u:
				StageId = input.ReadUInt32();
				break;
			}
		}
	}
}
