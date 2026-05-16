using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetStuffToAreaCsReq : IMessage<SetStuffToAreaCsReq>, IMessage, IEquatable<SetStuffToAreaCsReq>, IDeepCloneable<SetStuffToAreaCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetStuffToAreaCsReq> _parser = new MessageParser<SetStuffToAreaCsReq>(() => new SetStuffToAreaCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GKFEGIBGEGIFieldNumber = 2;

	private uint gKFEGIBGEGI_;

	public const int PEGELNHGMJAFieldNumber = 7;

	private uint pEGELNHGMJA_;

	public const int PosFieldNumber = 8;

	private JFFONIDPNDA pos_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetStuffToAreaCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetStuffToAreaCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint PEGELNHGMJA
	{
		get
		{
			return pEGELNHGMJA_;
		}
		set
		{
			pEGELNHGMJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFFONIDPNDA Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetStuffToAreaCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetStuffToAreaCsReq(SetStuffToAreaCsReq other)
		: this()
	{
		gKFEGIBGEGI_ = other.gKFEGIBGEGI_;
		pEGELNHGMJA_ = other.pEGELNHGMJA_;
		pos_ = other.pos_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetStuffToAreaCsReq Clone()
	{
		return new SetStuffToAreaCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetStuffToAreaCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetStuffToAreaCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GKFEGIBGEGI != other.GKFEGIBGEGI)
		{
			return false;
		}
		if (PEGELNHGMJA != other.PEGELNHGMJA)
		{
			return false;
		}
		if (Pos != other.Pos)
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
		if (GKFEGIBGEGI != 0)
		{
			num ^= GKFEGIBGEGI.GetHashCode();
		}
		if (PEGELNHGMJA != 0)
		{
			num ^= PEGELNHGMJA.GetHashCode();
		}
		if (Pos != JFFONIDPNDA.Pcpdhelpkem)
		{
			num ^= Pos.GetHashCode();
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
		if (GKFEGIBGEGI != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GKFEGIBGEGI);
		}
		if (PEGELNHGMJA != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(PEGELNHGMJA);
		}
		if (Pos != JFFONIDPNDA.Pcpdhelpkem)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)Pos);
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
		if (GKFEGIBGEGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GKFEGIBGEGI);
		}
		if (PEGELNHGMJA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PEGELNHGMJA);
		}
		if (Pos != JFFONIDPNDA.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Pos);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetStuffToAreaCsReq other)
	{
		if (other != null)
		{
			if (other.GKFEGIBGEGI != 0)
			{
				GKFEGIBGEGI = other.GKFEGIBGEGI;
			}
			if (other.PEGELNHGMJA != 0)
			{
				PEGELNHGMJA = other.PEGELNHGMJA;
			}
			if (other.Pos != JFFONIDPNDA.Pcpdhelpkem)
			{
				Pos = other.Pos;
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
				GKFEGIBGEGI = input.ReadUInt32();
				break;
			case 56u:
				PEGELNHGMJA = input.ReadUInt32();
				break;
			case 64u:
				Pos = (JFFONIDPNDA)input.ReadEnum();
				break;
			}
		}
	}
}
