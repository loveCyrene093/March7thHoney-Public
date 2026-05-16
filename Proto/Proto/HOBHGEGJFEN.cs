using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HOBHGEGJFEN : IMessage<HOBHGEGJFEN>, IMessage, IEquatable<HOBHGEGJFEN>, IDeepCloneable<HOBHGEGJFEN>, IBufferMessage
{
	private static readonly MessageParser<HOBHGEGJFEN> _parser = new MessageParser<HOBHGEGJFEN>(() => new HOBHGEGJFEN());

	private UnknownFieldSet _unknownFields;

	public const int FuncIdFieldNumber = 1;

	private uint funcId_;

	public const int NIKEEDLJHPDFieldNumber = 15;

	private bool nIKEEDLJHPD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HOBHGEGJFEN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HOBHGEGJFENReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FuncId
	{
		get
		{
			return funcId_;
		}
		set
		{
			funcId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NIKEEDLJHPD
	{
		get
		{
			return nIKEEDLJHPD_;
		}
		set
		{
			nIKEEDLJHPD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOBHGEGJFEN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOBHGEGJFEN(HOBHGEGJFEN other)
		: this()
	{
		funcId_ = other.funcId_;
		nIKEEDLJHPD_ = other.nIKEEDLJHPD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOBHGEGJFEN Clone()
	{
		return new HOBHGEGJFEN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HOBHGEGJFEN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HOBHGEGJFEN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FuncId != other.FuncId)
		{
			return false;
		}
		if (NIKEEDLJHPD != other.NIKEEDLJHPD)
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
		if (FuncId != 0)
		{
			num ^= FuncId.GetHashCode();
		}
		if (NIKEEDLJHPD)
		{
			num ^= NIKEEDLJHPD.GetHashCode();
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
		if (FuncId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(FuncId);
		}
		if (NIKEEDLJHPD)
		{
			output.WriteRawTag(120);
			output.WriteBool(NIKEEDLJHPD);
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
		if (FuncId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FuncId);
		}
		if (NIKEEDLJHPD)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HOBHGEGJFEN other)
	{
		if (other != null)
		{
			if (other.FuncId != 0)
			{
				FuncId = other.FuncId;
			}
			if (other.NIKEEDLJHPD)
			{
				NIKEEDLJHPD = other.NIKEEDLJHPD;
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
			case 8u:
				FuncId = input.ReadUInt32();
				break;
			case 120u:
				NIKEEDLJHPD = input.ReadBool();
				break;
			}
		}
	}
}
