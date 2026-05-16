using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DHBCCMMHNCK : IMessage<DHBCCMMHNCK>, IMessage, IEquatable<DHBCCMMHNCK>, IDeepCloneable<DHBCCMMHNCK>, IBufferMessage
{
	private static readonly MessageParser<DHBCCMMHNCK> _parser = new MessageParser<DHBCCMMHNCK>(() => new DHBCCMMHNCK());

	private UnknownFieldSet _unknownFields;

	public const int ScriptIdFieldNumber = 7;

	private uint scriptId_;

	public const int DDMOFHGIBLDFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_dDMOFHGIBLD_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> dDMOFHGIBLD_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DHBCCMMHNCK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DHBCCMMHNCKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScriptId
	{
		get
		{
			return scriptId_;
		}
		set
		{
			scriptId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DDMOFHGIBLD => dDMOFHGIBLD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DHBCCMMHNCK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DHBCCMMHNCK(DHBCCMMHNCK other)
		: this()
	{
		scriptId_ = other.scriptId_;
		dDMOFHGIBLD_ = other.dDMOFHGIBLD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DHBCCMMHNCK Clone()
	{
		return new DHBCCMMHNCK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DHBCCMMHNCK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DHBCCMMHNCK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ScriptId != other.ScriptId)
		{
			return false;
		}
		if (!dDMOFHGIBLD_.Equals(other.dDMOFHGIBLD_))
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
		if (ScriptId != 0)
		{
			num ^= ScriptId.GetHashCode();
		}
		num ^= dDMOFHGIBLD_.GetHashCode();
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
		if (ScriptId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ScriptId);
		}
		dDMOFHGIBLD_.WriteTo(ref output, _repeated_dDMOFHGIBLD_codec);
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
		if (ScriptId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScriptId);
		}
		num += dDMOFHGIBLD_.CalculateSize(_repeated_dDMOFHGIBLD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DHBCCMMHNCK other)
	{
		if (other != null)
		{
			if (other.ScriptId != 0)
			{
				ScriptId = other.ScriptId;
			}
			dDMOFHGIBLD_.Add(other.dDMOFHGIBLD_);
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
			case 56u:
				ScriptId = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				dDMOFHGIBLD_.AddEntriesFrom(ref input, _repeated_dDMOFHGIBLD_codec);
				break;
			}
		}
	}
}
