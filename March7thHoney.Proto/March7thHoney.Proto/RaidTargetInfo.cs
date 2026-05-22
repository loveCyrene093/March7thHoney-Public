using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RaidTargetInfo : IMessage<RaidTargetInfo>, IMessage, IEquatable<RaidTargetInfo>, IDeepCloneable<RaidTargetInfo>, IBufferMessage
{
	private static readonly MessageParser<RaidTargetInfo> _parser = new MessageParser<RaidTargetInfo>(() => new RaidTargetInfo());

	private UnknownFieldSet _unknownFields;

	public const int PDFLHJMCAHKFieldNumber = 1;

	private GKHEHCOMHCM pDFLHJMCAHK_;

	public const int JKCGCAMIFIAFieldNumber = 2;

	private uint jKCGCAMIFIA_;

	public const int GFBIMFHJAHAFieldNumber = 15;

	private uint gFBIMFHJAHA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RaidTargetInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RaidTargetInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GKHEHCOMHCM PDFLHJMCAHK
	{
		get
		{
			return pDFLHJMCAHK_;
		}
		set
		{
			pDFLHJMCAHK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKCGCAMIFIA
	{
		get
		{
			return jKCGCAMIFIA_;
		}
		set
		{
			jKCGCAMIFIA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GFBIMFHJAHA
	{
		get
		{
			return gFBIMFHJAHA_;
		}
		set
		{
			gFBIMFHJAHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RaidTargetInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RaidTargetInfo(RaidTargetInfo other)
		: this()
	{
		pDFLHJMCAHK_ = other.pDFLHJMCAHK_;
		jKCGCAMIFIA_ = other.jKCGCAMIFIA_;
		gFBIMFHJAHA_ = other.gFBIMFHJAHA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RaidTargetInfo Clone()
	{
		return new RaidTargetInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RaidTargetInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RaidTargetInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PDFLHJMCAHK != other.PDFLHJMCAHK)
		{
			return false;
		}
		if (JKCGCAMIFIA != other.JKCGCAMIFIA)
		{
			return false;
		}
		if (GFBIMFHJAHA != other.GFBIMFHJAHA)
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
		if (PDFLHJMCAHK != GKHEHCOMHCM.Pcpdhelpkem)
		{
			num ^= PDFLHJMCAHK.GetHashCode();
		}
		if (JKCGCAMIFIA != 0)
		{
			num ^= JKCGCAMIFIA.GetHashCode();
		}
		if (GFBIMFHJAHA != 0)
		{
			num ^= GFBIMFHJAHA.GetHashCode();
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
		if (PDFLHJMCAHK != GKHEHCOMHCM.Pcpdhelpkem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)PDFLHJMCAHK);
		}
		if (JKCGCAMIFIA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JKCGCAMIFIA);
		}
		if (GFBIMFHJAHA != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(GFBIMFHJAHA);
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
		if (PDFLHJMCAHK != GKHEHCOMHCM.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PDFLHJMCAHK);
		}
		if (JKCGCAMIFIA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKCGCAMIFIA);
		}
		if (GFBIMFHJAHA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GFBIMFHJAHA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RaidTargetInfo other)
	{
		if (other != null)
		{
			if (other.PDFLHJMCAHK != GKHEHCOMHCM.Pcpdhelpkem)
			{
				PDFLHJMCAHK = other.PDFLHJMCAHK;
			}
			if (other.JKCGCAMIFIA != 0)
			{
				JKCGCAMIFIA = other.JKCGCAMIFIA;
			}
			if (other.GFBIMFHJAHA != 0)
			{
				GFBIMFHJAHA = other.GFBIMFHJAHA;
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
				PDFLHJMCAHK = (GKHEHCOMHCM)input.ReadEnum();
				break;
			case 16u:
				JKCGCAMIFIA = input.ReadUInt32();
				break;
			case 120u:
				GFBIMFHJAHA = input.ReadUInt32();
				break;
			}
		}
	}
}
