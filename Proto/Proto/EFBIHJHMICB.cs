using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EFBIHJHMICB : IMessage<EFBIHJHMICB>, IMessage, IEquatable<EFBIHJHMICB>, IDeepCloneable<EFBIHJHMICB>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		FECOBCLAAMA = 4,
		CMBPMIHGHAK = 5,
		NBFJKDONMDF = 13
	}

	private static readonly MessageParser<EFBIHJHMICB> _parser = new MessageParser<EFBIHJHMICB>(() => new EFBIHJHMICB());

	private UnknownFieldSet _unknownFields;

	public const int UidFieldNumber = 2;

	private uint uid_;

	public const int DBOJCHBAHCIFieldNumber = 10;

	private uint dBOJCHBAHCI_;

	public const int FECOBCLAAMAFieldNumber = 4;

	public const int CMBPMIHGHAKFieldNumber = 5;

	public const int NBFJKDONMDFFieldNumber = 13;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EFBIHJHMICB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EFBIHJHMICBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DBOJCHBAHCI
	{
		get
		{
			return dBOJCHBAHCI_;
		}
		set
		{
			dBOJCHBAHCI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLGOMIMNNAE FECOBCLAAMA
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FECOBCLAAMA)
			{
				return null;
			}
			return (PLGOMIMNNAE)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FECOBCLAAMA : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GMGJALHOGOG CMBPMIHGHAK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CMBPMIHGHAK)
			{
				return null;
			}
			return (GMGJALHOGOG)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CMBPMIHGHAK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJKAKGBONBM NBFJKDONMDF
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.NBFJKDONMDF)
			{
				return null;
			}
			return (BJKAKGBONBM)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.NBFJKDONMDF : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFBIHJHMICB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFBIHJHMICB(EFBIHJHMICB other)
		: this()
	{
		uid_ = other.uid_;
		dBOJCHBAHCI_ = other.dBOJCHBAHCI_;
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.FECOBCLAAMA:
			FECOBCLAAMA = other.FECOBCLAAMA.Clone();
			break;
		case BPIHFAJCLOCOneofCase.CMBPMIHGHAK:
			CMBPMIHGHAK = other.CMBPMIHGHAK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.NBFJKDONMDF:
			NBFJKDONMDF = other.NBFJKDONMDF.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFBIHJHMICB Clone()
	{
		return new EFBIHJHMICB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EFBIHJHMICB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EFBIHJHMICB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (DBOJCHBAHCI != other.DBOJCHBAHCI)
		{
			return false;
		}
		if (!object.Equals(FECOBCLAAMA, other.FECOBCLAAMA))
		{
			return false;
		}
		if (!object.Equals(CMBPMIHGHAK, other.CMBPMIHGHAK))
		{
			return false;
		}
		if (!object.Equals(NBFJKDONMDF, other.NBFJKDONMDF))
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (DBOJCHBAHCI != 0)
		{
			num ^= DBOJCHBAHCI.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FECOBCLAAMA)
		{
			num ^= FECOBCLAAMA.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CMBPMIHGHAK)
		{
			num ^= CMBPMIHGHAK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NBFJKDONMDF)
		{
			num ^= NBFJKDONMDF.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
		if (Uid != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Uid);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FECOBCLAAMA)
		{
			output.WriteRawTag(34);
			output.WriteMessage(FECOBCLAAMA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CMBPMIHGHAK)
		{
			output.WriteRawTag(42);
			output.WriteMessage(CMBPMIHGHAK);
		}
		if (DBOJCHBAHCI != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(DBOJCHBAHCI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NBFJKDONMDF)
		{
			output.WriteRawTag(106);
			output.WriteMessage(NBFJKDONMDF);
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
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (DBOJCHBAHCI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DBOJCHBAHCI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FECOBCLAAMA)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FECOBCLAAMA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CMBPMIHGHAK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CMBPMIHGHAK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NBFJKDONMDF)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NBFJKDONMDF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EFBIHJHMICB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Uid != 0)
		{
			Uid = other.Uid;
		}
		if (other.DBOJCHBAHCI != 0)
		{
			DBOJCHBAHCI = other.DBOJCHBAHCI;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.FECOBCLAAMA:
			if (FECOBCLAAMA == null)
			{
				FECOBCLAAMA = new PLGOMIMNNAE();
			}
			FECOBCLAAMA.MergeFrom(other.FECOBCLAAMA);
			break;
		case BPIHFAJCLOCOneofCase.CMBPMIHGHAK:
			if (CMBPMIHGHAK == null)
			{
				CMBPMIHGHAK = new GMGJALHOGOG();
			}
			CMBPMIHGHAK.MergeFrom(other.CMBPMIHGHAK);
			break;
		case BPIHFAJCLOCOneofCase.NBFJKDONMDF:
			if (NBFJKDONMDF == null)
			{
				NBFJKDONMDF = new BJKAKGBONBM();
			}
			NBFJKDONMDF.MergeFrom(other.NBFJKDONMDF);
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
			case 16u:
				Uid = input.ReadUInt32();
				break;
			case 34u:
			{
				PLGOMIMNNAE pLGOMIMNNAE = new PLGOMIMNNAE();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FECOBCLAAMA)
				{
					pLGOMIMNNAE.MergeFrom(FECOBCLAAMA);
				}
				input.ReadMessage(pLGOMIMNNAE);
				FECOBCLAAMA = pLGOMIMNNAE;
				break;
			}
			case 42u:
			{
				GMGJALHOGOG gMGJALHOGOG = new GMGJALHOGOG();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CMBPMIHGHAK)
				{
					gMGJALHOGOG.MergeFrom(CMBPMIHGHAK);
				}
				input.ReadMessage(gMGJALHOGOG);
				CMBPMIHGHAK = gMGJALHOGOG;
				break;
			}
			case 80u:
				DBOJCHBAHCI = input.ReadUInt32();
				break;
			case 106u:
			{
				BJKAKGBONBM bJKAKGBONBM = new BJKAKGBONBM();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NBFJKDONMDF)
				{
					bJKAKGBONBM.MergeFrom(NBFJKDONMDF);
				}
				input.ReadMessage(bJKAKGBONBM);
				NBFJKDONMDF = bJKAKGBONBM;
				break;
			}
			}
		}
	}
}
