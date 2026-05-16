using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DGDHBAGEOOI : IMessage<DGDHBAGEOOI>, IMessage, IEquatable<DGDHBAGEOOI>, IDeepCloneable<DGDHBAGEOOI>, IBufferMessage
{
	private static readonly MessageParser<DGDHBAGEOOI> _parser = new MessageParser<DGDHBAGEOOI>(() => new DGDHBAGEOOI());

	private UnknownFieldSet _unknownFields;

	public const int AOLFFOLEJLBFieldNumber = 3;

	private bool aOLFFOLEJLB_;

	public const int DKLIONPKIIJFieldNumber = 4;

	private uint dKLIONPKIIJ_;

	public const int FPMCFJDOMDMFieldNumber = 5;

	private uint fPMCFJDOMDM_;

	public const int LOGPKCKNJELFieldNumber = 6;

	private uint lOGPKCKNJEL_;

	public const int BattleIdFieldNumber = 8;

	private uint battleId_;

	public const int JLELBCFOBKNFieldNumber = 11;

	private uint jLELBCFOBKN_;

	public const int JANDBBGLJEOFieldNumber = 14;

	private uint jANDBBGLJEO_;

	public const int KGKFADDEGNJFieldNumber = 15;

	private uint kGKFADDEGNJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DGDHBAGEOOI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DGDHBAGEOOIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AOLFFOLEJLB
	{
		get
		{
			return aOLFFOLEJLB_;
		}
		set
		{
			aOLFFOLEJLB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DKLIONPKIIJ
	{
		get
		{
			return dKLIONPKIIJ_;
		}
		set
		{
			dKLIONPKIIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FPMCFJDOMDM
	{
		get
		{
			return fPMCFJDOMDM_;
		}
		set
		{
			fPMCFJDOMDM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LOGPKCKNJEL
	{
		get
		{
			return lOGPKCKNJEL_;
		}
		set
		{
			lOGPKCKNJEL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BattleId
	{
		get
		{
			return battleId_;
		}
		set
		{
			battleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JLELBCFOBKN
	{
		get
		{
			return jLELBCFOBKN_;
		}
		set
		{
			jLELBCFOBKN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JANDBBGLJEO
	{
		get
		{
			return jANDBBGLJEO_;
		}
		set
		{
			jANDBBGLJEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KGKFADDEGNJ
	{
		get
		{
			return kGKFADDEGNJ_;
		}
		set
		{
			kGKFADDEGNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGDHBAGEOOI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGDHBAGEOOI(DGDHBAGEOOI other)
		: this()
	{
		aOLFFOLEJLB_ = other.aOLFFOLEJLB_;
		dKLIONPKIIJ_ = other.dKLIONPKIIJ_;
		fPMCFJDOMDM_ = other.fPMCFJDOMDM_;
		lOGPKCKNJEL_ = other.lOGPKCKNJEL_;
		battleId_ = other.battleId_;
		jLELBCFOBKN_ = other.jLELBCFOBKN_;
		jANDBBGLJEO_ = other.jANDBBGLJEO_;
		kGKFADDEGNJ_ = other.kGKFADDEGNJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGDHBAGEOOI Clone()
	{
		return new DGDHBAGEOOI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DGDHBAGEOOI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DGDHBAGEOOI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AOLFFOLEJLB != other.AOLFFOLEJLB)
		{
			return false;
		}
		if (DKLIONPKIIJ != other.DKLIONPKIIJ)
		{
			return false;
		}
		if (FPMCFJDOMDM != other.FPMCFJDOMDM)
		{
			return false;
		}
		if (LOGPKCKNJEL != other.LOGPKCKNJEL)
		{
			return false;
		}
		if (BattleId != other.BattleId)
		{
			return false;
		}
		if (JLELBCFOBKN != other.JLELBCFOBKN)
		{
			return false;
		}
		if (JANDBBGLJEO != other.JANDBBGLJEO)
		{
			return false;
		}
		if (KGKFADDEGNJ != other.KGKFADDEGNJ)
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
		if (AOLFFOLEJLB)
		{
			num ^= AOLFFOLEJLB.GetHashCode();
		}
		if (DKLIONPKIIJ != 0)
		{
			num ^= DKLIONPKIIJ.GetHashCode();
		}
		if (FPMCFJDOMDM != 0)
		{
			num ^= FPMCFJDOMDM.GetHashCode();
		}
		if (LOGPKCKNJEL != 0)
		{
			num ^= LOGPKCKNJEL.GetHashCode();
		}
		if (BattleId != 0)
		{
			num ^= BattleId.GetHashCode();
		}
		if (JLELBCFOBKN != 0)
		{
			num ^= JLELBCFOBKN.GetHashCode();
		}
		if (JANDBBGLJEO != 0)
		{
			num ^= JANDBBGLJEO.GetHashCode();
		}
		if (KGKFADDEGNJ != 0)
		{
			num ^= KGKFADDEGNJ.GetHashCode();
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
		if (AOLFFOLEJLB)
		{
			output.WriteRawTag(24);
			output.WriteBool(AOLFFOLEJLB);
		}
		if (DKLIONPKIIJ != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DKLIONPKIIJ);
		}
		if (FPMCFJDOMDM != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(FPMCFJDOMDM);
		}
		if (LOGPKCKNJEL != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(LOGPKCKNJEL);
		}
		if (BattleId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(BattleId);
		}
		if (JLELBCFOBKN != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(JLELBCFOBKN);
		}
		if (JANDBBGLJEO != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(JANDBBGLJEO);
		}
		if (KGKFADDEGNJ != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(KGKFADDEGNJ);
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
		if (AOLFFOLEJLB)
		{
			num += 2;
		}
		if (DKLIONPKIIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKLIONPKIIJ);
		}
		if (FPMCFJDOMDM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FPMCFJDOMDM);
		}
		if (LOGPKCKNJEL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LOGPKCKNJEL);
		}
		if (BattleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleId);
		}
		if (JLELBCFOBKN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JLELBCFOBKN);
		}
		if (JANDBBGLJEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JANDBBGLJEO);
		}
		if (KGKFADDEGNJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KGKFADDEGNJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DGDHBAGEOOI other)
	{
		if (other != null)
		{
			if (other.AOLFFOLEJLB)
			{
				AOLFFOLEJLB = other.AOLFFOLEJLB;
			}
			if (other.DKLIONPKIIJ != 0)
			{
				DKLIONPKIIJ = other.DKLIONPKIIJ;
			}
			if (other.FPMCFJDOMDM != 0)
			{
				FPMCFJDOMDM = other.FPMCFJDOMDM;
			}
			if (other.LOGPKCKNJEL != 0)
			{
				LOGPKCKNJEL = other.LOGPKCKNJEL;
			}
			if (other.BattleId != 0)
			{
				BattleId = other.BattleId;
			}
			if (other.JLELBCFOBKN != 0)
			{
				JLELBCFOBKN = other.JLELBCFOBKN;
			}
			if (other.JANDBBGLJEO != 0)
			{
				JANDBBGLJEO = other.JANDBBGLJEO;
			}
			if (other.KGKFADDEGNJ != 0)
			{
				KGKFADDEGNJ = other.KGKFADDEGNJ;
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
				AOLFFOLEJLB = input.ReadBool();
				break;
			case 32u:
				DKLIONPKIIJ = input.ReadUInt32();
				break;
			case 40u:
				FPMCFJDOMDM = input.ReadUInt32();
				break;
			case 48u:
				LOGPKCKNJEL = input.ReadUInt32();
				break;
			case 64u:
				BattleId = input.ReadUInt32();
				break;
			case 88u:
				JLELBCFOBKN = input.ReadUInt32();
				break;
			case 112u:
				JANDBBGLJEO = input.ReadUInt32();
				break;
			case 120u:
				KGKFADDEGNJ = input.ReadUInt32();
				break;
			}
		}
	}
}
