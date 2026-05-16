using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KNGLMKEJBAB : IMessage<KNGLMKEJBAB>, IMessage, IEquatable<KNGLMKEJBAB>, IDeepCloneable<KNGLMKEJBAB>, IBufferMessage
{
	private static readonly MessageParser<KNGLMKEJBAB> _parser = new MessageParser<KNGLMKEJBAB>(() => new KNGLMKEJBAB());

	private UnknownFieldSet _unknownFields;

	public const int MGNHPGHMADGFieldNumber = 1;

	private int mGNHPGHMADG_;

	public const int ConfigIdFieldNumber = 4;

	private uint configId_;

	public const int NDAECAPOPAIFieldNumber = 6;

	private OMJLLILGAEP nDAECAPOPAI_;

	public const int JHPHHBJIICKFieldNumber = 7;

	private OMJLLILGAEP jHPHHBJIICK_;

	public const int NOJEAOJHDALFieldNumber = 8;

	private int nOJEAOJHDAL_;

	public const int InteractIdFieldNumber = 9;

	private uint interactId_;

	public const int JBGBALEFMHHFieldNumber = 10;

	private uint jBGBALEFMHH_;

	public const int IILMEIAMDNCFieldNumber = 11;

	private uint iILMEIAMDNC_;

	public const int PCKJPEEGDGBFieldNumber = 14;

	private int pCKJPEEGDGB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KNGLMKEJBAB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KNGLMKEJBABReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MGNHPGHMADG
	{
		get
		{
			return mGNHPGHMADG_;
		}
		set
		{
			mGNHPGHMADG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ConfigId
	{
		get
		{
			return configId_;
		}
		set
		{
			configId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMJLLILGAEP NDAECAPOPAI
	{
		get
		{
			return nDAECAPOPAI_;
		}
		set
		{
			nDAECAPOPAI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMJLLILGAEP JHPHHBJIICK
	{
		get
		{
			return jHPHHBJIICK_;
		}
		set
		{
			jHPHHBJIICK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NOJEAOJHDAL
	{
		get
		{
			return nOJEAOJHDAL_;
		}
		set
		{
			nOJEAOJHDAL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint InteractId
	{
		get
		{
			return interactId_;
		}
		set
		{
			interactId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JBGBALEFMHH
	{
		get
		{
			return jBGBALEFMHH_;
		}
		set
		{
			jBGBALEFMHH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IILMEIAMDNC
	{
		get
		{
			return iILMEIAMDNC_;
		}
		set
		{
			iILMEIAMDNC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PCKJPEEGDGB
	{
		get
		{
			return pCKJPEEGDGB_;
		}
		set
		{
			pCKJPEEGDGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNGLMKEJBAB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNGLMKEJBAB(KNGLMKEJBAB other)
		: this()
	{
		mGNHPGHMADG_ = other.mGNHPGHMADG_;
		configId_ = other.configId_;
		nDAECAPOPAI_ = ((other.nDAECAPOPAI_ != null) ? other.nDAECAPOPAI_.Clone() : null);
		jHPHHBJIICK_ = ((other.jHPHHBJIICK_ != null) ? other.jHPHHBJIICK_.Clone() : null);
		nOJEAOJHDAL_ = other.nOJEAOJHDAL_;
		interactId_ = other.interactId_;
		jBGBALEFMHH_ = other.jBGBALEFMHH_;
		iILMEIAMDNC_ = other.iILMEIAMDNC_;
		pCKJPEEGDGB_ = other.pCKJPEEGDGB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNGLMKEJBAB Clone()
	{
		return new KNGLMKEJBAB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KNGLMKEJBAB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KNGLMKEJBAB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MGNHPGHMADG != other.MGNHPGHMADG)
		{
			return false;
		}
		if (ConfigId != other.ConfigId)
		{
			return false;
		}
		if (!object.Equals(NDAECAPOPAI, other.NDAECAPOPAI))
		{
			return false;
		}
		if (!object.Equals(JHPHHBJIICK, other.JHPHHBJIICK))
		{
			return false;
		}
		if (NOJEAOJHDAL != other.NOJEAOJHDAL)
		{
			return false;
		}
		if (InteractId != other.InteractId)
		{
			return false;
		}
		if (JBGBALEFMHH != other.JBGBALEFMHH)
		{
			return false;
		}
		if (IILMEIAMDNC != other.IILMEIAMDNC)
		{
			return false;
		}
		if (PCKJPEEGDGB != other.PCKJPEEGDGB)
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
		if (MGNHPGHMADG != 0)
		{
			num ^= MGNHPGHMADG.GetHashCode();
		}
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
		}
		if (nDAECAPOPAI_ != null)
		{
			num ^= NDAECAPOPAI.GetHashCode();
		}
		if (jHPHHBJIICK_ != null)
		{
			num ^= JHPHHBJIICK.GetHashCode();
		}
		if (NOJEAOJHDAL != 0)
		{
			num ^= NOJEAOJHDAL.GetHashCode();
		}
		if (InteractId != 0)
		{
			num ^= InteractId.GetHashCode();
		}
		if (JBGBALEFMHH != 0)
		{
			num ^= JBGBALEFMHH.GetHashCode();
		}
		if (IILMEIAMDNC != 0)
		{
			num ^= IILMEIAMDNC.GetHashCode();
		}
		if (PCKJPEEGDGB != 0)
		{
			num ^= PCKJPEEGDGB.GetHashCode();
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
		if (MGNHPGHMADG != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(MGNHPGHMADG);
		}
		if (ConfigId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ConfigId);
		}
		if (nDAECAPOPAI_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(NDAECAPOPAI);
		}
		if (jHPHHBJIICK_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(JHPHHBJIICK);
		}
		if (NOJEAOJHDAL != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(NOJEAOJHDAL);
		}
		if (InteractId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(InteractId);
		}
		if (JBGBALEFMHH != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(JBGBALEFMHH);
		}
		if (IILMEIAMDNC != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(IILMEIAMDNC);
		}
		if (PCKJPEEGDGB != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(PCKJPEEGDGB);
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
		if (MGNHPGHMADG != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MGNHPGHMADG);
		}
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ConfigId);
		}
		if (nDAECAPOPAI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NDAECAPOPAI);
		}
		if (jHPHHBJIICK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JHPHHBJIICK);
		}
		if (NOJEAOJHDAL != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NOJEAOJHDAL);
		}
		if (InteractId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(InteractId);
		}
		if (JBGBALEFMHH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JBGBALEFMHH);
		}
		if (IILMEIAMDNC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IILMEIAMDNC);
		}
		if (PCKJPEEGDGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PCKJPEEGDGB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KNGLMKEJBAB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MGNHPGHMADG != 0)
		{
			MGNHPGHMADG = other.MGNHPGHMADG;
		}
		if (other.ConfigId != 0)
		{
			ConfigId = other.ConfigId;
		}
		if (other.nDAECAPOPAI_ != null)
		{
			if (nDAECAPOPAI_ == null)
			{
				NDAECAPOPAI = new OMJLLILGAEP();
			}
			NDAECAPOPAI.MergeFrom(other.NDAECAPOPAI);
		}
		if (other.jHPHHBJIICK_ != null)
		{
			if (jHPHHBJIICK_ == null)
			{
				JHPHHBJIICK = new OMJLLILGAEP();
			}
			JHPHHBJIICK.MergeFrom(other.JHPHHBJIICK);
		}
		if (other.NOJEAOJHDAL != 0)
		{
			NOJEAOJHDAL = other.NOJEAOJHDAL;
		}
		if (other.InteractId != 0)
		{
			InteractId = other.InteractId;
		}
		if (other.JBGBALEFMHH != 0)
		{
			JBGBALEFMHH = other.JBGBALEFMHH;
		}
		if (other.IILMEIAMDNC != 0)
		{
			IILMEIAMDNC = other.IILMEIAMDNC;
		}
		if (other.PCKJPEEGDGB != 0)
		{
			PCKJPEEGDGB = other.PCKJPEEGDGB;
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
			case 8u:
				MGNHPGHMADG = input.ReadInt32();
				break;
			case 32u:
				ConfigId = input.ReadUInt32();
				break;
			case 50u:
				if (nDAECAPOPAI_ == null)
				{
					NDAECAPOPAI = new OMJLLILGAEP();
				}
				input.ReadMessage(NDAECAPOPAI);
				break;
			case 58u:
				if (jHPHHBJIICK_ == null)
				{
					JHPHHBJIICK = new OMJLLILGAEP();
				}
				input.ReadMessage(JHPHHBJIICK);
				break;
			case 64u:
				NOJEAOJHDAL = input.ReadInt32();
				break;
			case 72u:
				InteractId = input.ReadUInt32();
				break;
			case 80u:
				JBGBALEFMHH = input.ReadUInt32();
				break;
			case 88u:
				IILMEIAMDNC = input.ReadUInt32();
				break;
			case 112u:
				PCKJPEEGDGB = input.ReadInt32();
				break;
			}
		}
	}
}
