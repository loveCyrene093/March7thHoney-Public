using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OKBFGNELFMG : IMessage<OKBFGNELFMG>, IMessage, IEquatable<OKBFGNELFMG>, IDeepCloneable<OKBFGNELFMG>, IBufferMessage
{
	private static readonly MessageParser<OKBFGNELFMG> _parser = new MessageParser<OKBFGNELFMG>(() => new OKBFGNELFMG());

	private UnknownFieldSet _unknownFields;

	public const int DKJFDLKJLBEFieldNumber = 3;

	private bool dKJFDLKJLBE_;

	public const int HALMBJJIKONFieldNumber = 4;

	private uint hALMBJJIKON_;

	public const int CBCHIPFAHMGFieldNumber = 14;

	private uint cBCHIPFAHMG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OKBFGNELFMG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OKBFGNELFMGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DKJFDLKJLBE
	{
		get
		{
			return dKJFDLKJLBE_;
		}
		set
		{
			dKJFDLKJLBE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HALMBJJIKON
	{
		get
		{
			return hALMBJJIKON_;
		}
		set
		{
			hALMBJJIKON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CBCHIPFAHMG
	{
		get
		{
			return cBCHIPFAHMG_;
		}
		set
		{
			cBCHIPFAHMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKBFGNELFMG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKBFGNELFMG(OKBFGNELFMG other)
		: this()
	{
		dKJFDLKJLBE_ = other.dKJFDLKJLBE_;
		hALMBJJIKON_ = other.hALMBJJIKON_;
		cBCHIPFAHMG_ = other.cBCHIPFAHMG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKBFGNELFMG Clone()
	{
		return new OKBFGNELFMG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OKBFGNELFMG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OKBFGNELFMG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DKJFDLKJLBE != other.DKJFDLKJLBE)
		{
			return false;
		}
		if (HALMBJJIKON != other.HALMBJJIKON)
		{
			return false;
		}
		if (CBCHIPFAHMG != other.CBCHIPFAHMG)
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
		if (DKJFDLKJLBE)
		{
			num ^= DKJFDLKJLBE.GetHashCode();
		}
		if (HALMBJJIKON != 0)
		{
			num ^= HALMBJJIKON.GetHashCode();
		}
		if (CBCHIPFAHMG != 0)
		{
			num ^= CBCHIPFAHMG.GetHashCode();
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
		if (DKJFDLKJLBE)
		{
			output.WriteRawTag(24);
			output.WriteBool(DKJFDLKJLBE);
		}
		if (HALMBJJIKON != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(HALMBJJIKON);
		}
		if (CBCHIPFAHMG != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CBCHIPFAHMG);
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
		if (DKJFDLKJLBE)
		{
			num += 2;
		}
		if (HALMBJJIKON != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HALMBJJIKON);
		}
		if (CBCHIPFAHMG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CBCHIPFAHMG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OKBFGNELFMG other)
	{
		if (other != null)
		{
			if (other.DKJFDLKJLBE)
			{
				DKJFDLKJLBE = other.DKJFDLKJLBE;
			}
			if (other.HALMBJJIKON != 0)
			{
				HALMBJJIKON = other.HALMBJJIKON;
			}
			if (other.CBCHIPFAHMG != 0)
			{
				CBCHIPFAHMG = other.CBCHIPFAHMG;
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
			case 24u:
				DKJFDLKJLBE = input.ReadBool();
				break;
			case 32u:
				HALMBJJIKON = input.ReadUInt32();
				break;
			case 112u:
				CBCHIPFAHMG = input.ReadUInt32();
				break;
			}
		}
	}
}
