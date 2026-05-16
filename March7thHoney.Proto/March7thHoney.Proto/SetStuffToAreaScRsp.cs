using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetStuffToAreaScRsp : IMessage<SetStuffToAreaScRsp>, IMessage, IEquatable<SetStuffToAreaScRsp>, IDeepCloneable<SetStuffToAreaScRsp>, IBufferMessage
{
	private static readonly MessageParser<SetStuffToAreaScRsp> _parser = new MessageParser<SetStuffToAreaScRsp>(() => new SetStuffToAreaScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int PEGELNHGMJAFieldNumber = 2;

	private uint pEGELNHGMJA_;

	public const int GKFEGIBGEGIFieldNumber = 5;

	private uint gKFEGIBGEGI_;

	public const int PosFieldNumber = 8;

	private JFFONIDPNDA pos_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetStuffToAreaScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetStuffToAreaScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public SetStuffToAreaScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetStuffToAreaScRsp(SetStuffToAreaScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		pEGELNHGMJA_ = other.pEGELNHGMJA_;
		gKFEGIBGEGI_ = other.gKFEGIBGEGI_;
		pos_ = other.pos_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetStuffToAreaScRsp Clone()
	{
		return new SetStuffToAreaScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetStuffToAreaScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetStuffToAreaScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (PEGELNHGMJA != other.PEGELNHGMJA)
		{
			return false;
		}
		if (GKFEGIBGEGI != other.GKFEGIBGEGI)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (PEGELNHGMJA != 0)
		{
			num ^= PEGELNHGMJA.GetHashCode();
		}
		if (GKFEGIBGEGI != 0)
		{
			num ^= GKFEGIBGEGI.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (PEGELNHGMJA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PEGELNHGMJA);
		}
		if (GKFEGIBGEGI != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GKFEGIBGEGI);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (PEGELNHGMJA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PEGELNHGMJA);
		}
		if (GKFEGIBGEGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GKFEGIBGEGI);
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
	public void MergeFrom(SetStuffToAreaScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.PEGELNHGMJA != 0)
			{
				PEGELNHGMJA = other.PEGELNHGMJA;
			}
			if (other.GKFEGIBGEGI != 0)
			{
				GKFEGIBGEGI = other.GKFEGIBGEGI;
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
			case 8u:
				Retcode = input.ReadUInt32();
				break;
			case 16u:
				PEGELNHGMJA = input.ReadUInt32();
				break;
			case 40u:
				GKFEGIBGEGI = input.ReadUInt32();
				break;
			case 64u:
				Pos = (JFFONIDPNDA)input.ReadEnum();
				break;
			}
		}
	}
}
