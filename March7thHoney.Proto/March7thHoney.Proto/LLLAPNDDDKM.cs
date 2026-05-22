using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LLLAPNDDDKM : IMessage<LLLAPNDDDKM>, IMessage, IEquatable<LLLAPNDDDKM>, IDeepCloneable<LLLAPNDDDKM>, IBufferMessage
{
	private static readonly MessageParser<LLLAPNDDDKM> _parser = new MessageParser<LLLAPNDDDKM>(() => new LLLAPNDDDKM());

	private UnknownFieldSet _unknownFields;

	public const int OGHCMDFNGMFFieldNumber = 3;

	private uint oGHCMDFNGMF_;

	public const int NPBKLCHLJMGFieldNumber = 4;

	private uint nPBKLCHLJMG_;

	public const int AvatarIdFieldNumber = 6;

	private uint avatarId_;

	public const int NBAKHCLLEKJFieldNumber = 13;

	private CPIOCHHPICD nBAKHCLLEKJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LLLAPNDDDKM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LLLAPNDDDKMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OGHCMDFNGMF
	{
		get
		{
			return oGHCMDFNGMF_;
		}
		set
		{
			oGHCMDFNGMF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NPBKLCHLJMG
	{
		get
		{
			return nPBKLCHLJMG_;
		}
		set
		{
			nPBKLCHLJMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CPIOCHHPICD NBAKHCLLEKJ
	{
		get
		{
			return nBAKHCLLEKJ_;
		}
		set
		{
			nBAKHCLLEKJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLLAPNDDDKM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLLAPNDDDKM(LLLAPNDDDKM other)
		: this()
	{
		oGHCMDFNGMF_ = other.oGHCMDFNGMF_;
		nPBKLCHLJMG_ = other.nPBKLCHLJMG_;
		avatarId_ = other.avatarId_;
		nBAKHCLLEKJ_ = ((other.nBAKHCLLEKJ_ != null) ? other.nBAKHCLLEKJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLLAPNDDDKM Clone()
	{
		return new LLLAPNDDDKM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LLLAPNDDDKM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LLLAPNDDDKM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OGHCMDFNGMF != other.OGHCMDFNGMF)
		{
			return false;
		}
		if (NPBKLCHLJMG != other.NPBKLCHLJMG)
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (!object.Equals(NBAKHCLLEKJ, other.NBAKHCLLEKJ))
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
		if (OGHCMDFNGMF != 0)
		{
			num ^= OGHCMDFNGMF.GetHashCode();
		}
		if (NPBKLCHLJMG != 0)
		{
			num ^= NPBKLCHLJMG.GetHashCode();
		}
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (nBAKHCLLEKJ_ != null)
		{
			num ^= NBAKHCLLEKJ.GetHashCode();
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
		if (OGHCMDFNGMF != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(OGHCMDFNGMF);
		}
		if (NPBKLCHLJMG != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(NPBKLCHLJMG);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(AvatarId);
		}
		if (nBAKHCLLEKJ_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(NBAKHCLLEKJ);
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
		if (OGHCMDFNGMF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OGHCMDFNGMF);
		}
		if (NPBKLCHLJMG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NPBKLCHLJMG);
		}
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (nBAKHCLLEKJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NBAKHCLLEKJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LLLAPNDDDKM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.OGHCMDFNGMF != 0)
		{
			OGHCMDFNGMF = other.OGHCMDFNGMF;
		}
		if (other.NPBKLCHLJMG != 0)
		{
			NPBKLCHLJMG = other.NPBKLCHLJMG;
		}
		if (other.AvatarId != 0)
		{
			AvatarId = other.AvatarId;
		}
		if (other.nBAKHCLLEKJ_ != null)
		{
			if (nBAKHCLLEKJ_ == null)
			{
				NBAKHCLLEKJ = new CPIOCHHPICD();
			}
			NBAKHCLLEKJ.MergeFrom(other.NBAKHCLLEKJ);
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
			case 24u:
				OGHCMDFNGMF = input.ReadUInt32();
				break;
			case 32u:
				NPBKLCHLJMG = input.ReadUInt32();
				break;
			case 48u:
				AvatarId = input.ReadUInt32();
				break;
			case 106u:
				if (nBAKHCLLEKJ_ == null)
				{
					NBAKHCLLEKJ = new CPIOCHHPICD();
				}
				input.ReadMessage(NBAKHCLLEKJ);
				break;
			}
		}
	}
}
