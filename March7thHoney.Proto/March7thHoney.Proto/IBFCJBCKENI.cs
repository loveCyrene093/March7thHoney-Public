using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IBFCJBCKENI : IMessage<IBFCJBCKENI>, IMessage, IEquatable<IBFCJBCKENI>, IDeepCloneable<IBFCJBCKENI>, IBufferMessage
{
	private static readonly MessageParser<IBFCJBCKENI> _parser = new MessageParser<IBFCJBCKENI>(() => new IBFCJBCKENI());

	private UnknownFieldSet _unknownFields;

	public const int GBHLNDOOLLGFieldNumber = 2;

	private uint gBHLNDOOLLG_;

	public const int CurFundFieldNumber = 9;

	private uint curFund_;

	public const int GKFEGIBGEGIFieldNumber = 12;

	private uint gKFEGIBGEGI_;

	public const int DOBCFDEIMKAFieldNumber = 15;

	private uint dOBCFDEIMKA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IBFCJBCKENI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IBFCJBCKENIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GBHLNDOOLLG
	{
		get
		{
			return gBHLNDOOLLG_;
		}
		set
		{
			gBHLNDOOLLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurFund
	{
		get
		{
			return curFund_;
		}
		set
		{
			curFund_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GKFEGIBGEGI
	{
		get
		{
			return gKFEGIBGEGI_;
		}
		set
		{
			gKFEGIBGEGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DOBCFDEIMKA
	{
		get
		{
			return dOBCFDEIMKA_;
		}
		set
		{
			dOBCFDEIMKA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IBFCJBCKENI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IBFCJBCKENI(IBFCJBCKENI other)
		: this()
	{
		gBHLNDOOLLG_ = other.gBHLNDOOLLG_;
		curFund_ = other.curFund_;
		gKFEGIBGEGI_ = other.gKFEGIBGEGI_;
		dOBCFDEIMKA_ = other.dOBCFDEIMKA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IBFCJBCKENI Clone()
	{
		return new IBFCJBCKENI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IBFCJBCKENI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IBFCJBCKENI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GBHLNDOOLLG != other.GBHLNDOOLLG)
		{
			return false;
		}
		if (CurFund != other.CurFund)
		{
			return false;
		}
		if (GKFEGIBGEGI != other.GKFEGIBGEGI)
		{
			return false;
		}
		if (DOBCFDEIMKA != other.DOBCFDEIMKA)
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
		if (GBHLNDOOLLG != 0)
		{
			num ^= GBHLNDOOLLG.GetHashCode();
		}
		if (CurFund != 0)
		{
			num ^= CurFund.GetHashCode();
		}
		if (GKFEGIBGEGI != 0)
		{
			num ^= GKFEGIBGEGI.GetHashCode();
		}
		if (DOBCFDEIMKA != 0)
		{
			num ^= DOBCFDEIMKA.GetHashCode();
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
		if (GBHLNDOOLLG != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GBHLNDOOLLG);
		}
		if (CurFund != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(CurFund);
		}
		if (GKFEGIBGEGI != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(GKFEGIBGEGI);
		}
		if (DOBCFDEIMKA != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(DOBCFDEIMKA);
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
		if (GBHLNDOOLLG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GBHLNDOOLLG);
		}
		if (CurFund != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurFund);
		}
		if (GKFEGIBGEGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GKFEGIBGEGI);
		}
		if (DOBCFDEIMKA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DOBCFDEIMKA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IBFCJBCKENI other)
	{
		if (other != null)
		{
			if (other.GBHLNDOOLLG != 0)
			{
				GBHLNDOOLLG = other.GBHLNDOOLLG;
			}
			if (other.CurFund != 0)
			{
				CurFund = other.CurFund;
			}
			if (other.GKFEGIBGEGI != 0)
			{
				GKFEGIBGEGI = other.GKFEGIBGEGI;
			}
			if (other.DOBCFDEIMKA != 0)
			{
				DOBCFDEIMKA = other.DOBCFDEIMKA;
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
				GBHLNDOOLLG = input.ReadUInt32();
				break;
			case 72u:
				CurFund = input.ReadUInt32();
				break;
			case 96u:
				GKFEGIBGEGI = input.ReadUInt32();
				break;
			case 120u:
				DOBCFDEIMKA = input.ReadUInt32();
				break;
			}
		}
	}
}
