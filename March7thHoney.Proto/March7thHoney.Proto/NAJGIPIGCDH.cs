using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NAJGIPIGCDH : IMessage<NAJGIPIGCDH>, IMessage, IEquatable<NAJGIPIGCDH>, IDeepCloneable<NAJGIPIGCDH>, IBufferMessage
{
	public enum BEEPACPFOOLOneofCase
	{
		None = 0,
		NJELGEBHAOP = 1495,
		MEBMDLBPEHO = 1675
	}

	private static readonly MessageParser<NAJGIPIGCDH> _parser = new MessageParser<NAJGIPIGCDH>(() => new NAJGIPIGCDH());

	private UnknownFieldSet _unknownFields;

	public const int HKGKNEKKJHBFieldNumber = 2;

	private ClockParkBuffList hKGKNEKKJHB_;

	public const int ScriptIdFieldNumber = 4;

	private uint scriptId_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int NNFAMOJAHCHFieldNumber = 8;

	private uint nNFAMOJAHCH_;

	public const int NJELGEBHAOPFieldNumber = 1495;

	public const int MEBMDLBPEHOFieldNumber = 1675;

	private object bEEPACPFOOL_;

	private BEEPACPFOOLOneofCase bEEPACPFOOLCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NAJGIPIGCDH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NAJGIPIGCDHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkBuffList HKGKNEKKJHB
	{
		get
		{
			return hKGKNEKKJHB_;
		}
		set
		{
			hKGKNEKKJHB_ = value;
		}
	}

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
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NNFAMOJAHCH
	{
		get
		{
			return nNFAMOJAHCH_;
		}
		set
		{
			nNFAMOJAHCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBECBMMMDHC NJELGEBHAOP
	{
		get
		{
			if (bEEPACPFOOLCase_ != BEEPACPFOOLOneofCase.NJELGEBHAOP)
			{
				return null;
			}
			return (OBECBMMMDHC)bEEPACPFOOL_;
		}
		set
		{
			bEEPACPFOOL_ = value;
			bEEPACPFOOLCase_ = ((value != null) ? BEEPACPFOOLOneofCase.NJELGEBHAOP : BEEPACPFOOLOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHAKADEKJEJ MEBMDLBPEHO
	{
		get
		{
			if (bEEPACPFOOLCase_ != BEEPACPFOOLOneofCase.MEBMDLBPEHO)
			{
				return null;
			}
			return (JHAKADEKJEJ)bEEPACPFOOL_;
		}
		set
		{
			bEEPACPFOOL_ = value;
			bEEPACPFOOLCase_ = ((value != null) ? BEEPACPFOOLOneofCase.MEBMDLBPEHO : BEEPACPFOOLOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BEEPACPFOOLOneofCase BEEPACPFOOLCase => bEEPACPFOOLCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAJGIPIGCDH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAJGIPIGCDH(NAJGIPIGCDH other)
		: this()
	{
		hKGKNEKKJHB_ = ((other.hKGKNEKKJHB_ != null) ? other.hKGKNEKKJHB_.Clone() : null);
		scriptId_ = other.scriptId_;
		retcode_ = other.retcode_;
		nNFAMOJAHCH_ = other.nNFAMOJAHCH_;
		switch (other.BEEPACPFOOLCase)
		{
		case BEEPACPFOOLOneofCase.NJELGEBHAOP:
			NJELGEBHAOP = other.NJELGEBHAOP.Clone();
			break;
		case BEEPACPFOOLOneofCase.MEBMDLBPEHO:
			MEBMDLBPEHO = other.MEBMDLBPEHO.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAJGIPIGCDH Clone()
	{
		return new NAJGIPIGCDH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBEEPACPFOOL()
	{
		bEEPACPFOOLCase_ = BEEPACPFOOLOneofCase.None;
		bEEPACPFOOL_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NAJGIPIGCDH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NAJGIPIGCDH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HKGKNEKKJHB, other.HKGKNEKKJHB))
		{
			return false;
		}
		if (ScriptId != other.ScriptId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (NNFAMOJAHCH != other.NNFAMOJAHCH)
		{
			return false;
		}
		if (!object.Equals(NJELGEBHAOP, other.NJELGEBHAOP))
		{
			return false;
		}
		if (!object.Equals(MEBMDLBPEHO, other.MEBMDLBPEHO))
		{
			return false;
		}
		if (BEEPACPFOOLCase != other.BEEPACPFOOLCase)
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
		if (hKGKNEKKJHB_ != null)
		{
			num ^= HKGKNEKKJHB.GetHashCode();
		}
		if (ScriptId != 0)
		{
			num ^= ScriptId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (NNFAMOJAHCH != 0)
		{
			num ^= NNFAMOJAHCH.GetHashCode();
		}
		if (bEEPACPFOOLCase_ == BEEPACPFOOLOneofCase.NJELGEBHAOP)
		{
			num ^= NJELGEBHAOP.GetHashCode();
		}
		if (bEEPACPFOOLCase_ == BEEPACPFOOLOneofCase.MEBMDLBPEHO)
		{
			num ^= MEBMDLBPEHO.GetHashCode();
		}
		num ^= (int)bEEPACPFOOLCase_;
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
		if (hKGKNEKKJHB_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(HKGKNEKKJHB);
		}
		if (ScriptId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ScriptId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (NNFAMOJAHCH != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(NNFAMOJAHCH);
		}
		if (bEEPACPFOOLCase_ == BEEPACPFOOLOneofCase.NJELGEBHAOP)
		{
			output.WriteRawTag(186, 93);
			output.WriteMessage(NJELGEBHAOP);
		}
		if (bEEPACPFOOLCase_ == BEEPACPFOOLOneofCase.MEBMDLBPEHO)
		{
			output.WriteRawTag(218, 104);
			output.WriteMessage(MEBMDLBPEHO);
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
		if (hKGKNEKKJHB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HKGKNEKKJHB);
		}
		if (ScriptId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScriptId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (NNFAMOJAHCH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NNFAMOJAHCH);
		}
		if (bEEPACPFOOLCase_ == BEEPACPFOOLOneofCase.NJELGEBHAOP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NJELGEBHAOP);
		}
		if (bEEPACPFOOLCase_ == BEEPACPFOOLOneofCase.MEBMDLBPEHO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MEBMDLBPEHO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NAJGIPIGCDH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.hKGKNEKKJHB_ != null)
		{
			if (hKGKNEKKJHB_ == null)
			{
				HKGKNEKKJHB = new ClockParkBuffList();
			}
			HKGKNEKKJHB.MergeFrom(other.HKGKNEKKJHB);
		}
		if (other.ScriptId != 0)
		{
			ScriptId = other.ScriptId;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.NNFAMOJAHCH != 0)
		{
			NNFAMOJAHCH = other.NNFAMOJAHCH;
		}
		switch (other.BEEPACPFOOLCase)
		{
		case BEEPACPFOOLOneofCase.NJELGEBHAOP:
			if (NJELGEBHAOP == null)
			{
				NJELGEBHAOP = new OBECBMMMDHC();
			}
			NJELGEBHAOP.MergeFrom(other.NJELGEBHAOP);
			break;
		case BEEPACPFOOLOneofCase.MEBMDLBPEHO:
			if (MEBMDLBPEHO == null)
			{
				MEBMDLBPEHO = new JHAKADEKJEJ();
			}
			MEBMDLBPEHO.MergeFrom(other.MEBMDLBPEHO);
			break;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 18u:
				if (hKGKNEKKJHB_ == null)
				{
					HKGKNEKKJHB = new ClockParkBuffList();
				}
				input.ReadMessage(HKGKNEKKJHB);
				break;
			case 32u:
				ScriptId = input.ReadUInt32();
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 64u:
				NNFAMOJAHCH = input.ReadUInt32();
				break;
			case 11962u:
			{
				OBECBMMMDHC oBECBMMMDHC = new OBECBMMMDHC();
				if (bEEPACPFOOLCase_ == BEEPACPFOOLOneofCase.NJELGEBHAOP)
				{
					oBECBMMMDHC.MergeFrom(NJELGEBHAOP);
				}
				input.ReadMessage(oBECBMMMDHC);
				NJELGEBHAOP = oBECBMMMDHC;
				break;
			}
			case 13402u:
			{
				JHAKADEKJEJ jHAKADEKJEJ = new JHAKADEKJEJ();
				if (bEEPACPFOOLCase_ == BEEPACPFOOLOneofCase.MEBMDLBPEHO)
				{
					jHAKADEKJEJ.MergeFrom(MEBMDLBPEHO);
				}
				input.ReadMessage(jHAKADEKJEJ);
				MEBMDLBPEHO = jHAKADEKJEJ;
				break;
			}
			}
		}
	}
}
