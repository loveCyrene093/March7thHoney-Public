using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueMagicSettleScRsp : IMessage<RogueMagicSettleScRsp>, IMessage, IEquatable<RogueMagicSettleScRsp>, IDeepCloneable<RogueMagicSettleScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueMagicSettleScRsp> _parser = new MessageParser<RogueMagicSettleScRsp>(() => new RogueMagicSettleScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int MJPEJPMACFGFieldNumber = 6;

	private OJFDEKIPPJF mJPEJPMACFG_;

	public const int FNKEBOFAHMEFieldNumber = 7;

	private ItemList fNKEBOFAHME_;

	public const int AFLJJJFCBINFieldNumber = 11;

	private JKAIDKIGEGP aFLJJJFCBIN_;

	public const int EDKJMPACHNJFieldNumber = 13;

	private BHMJAJGOJPM eDKJMPACHNJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueMagicSettleScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueMagicSettleScRspReflection.Descriptor.MessageTypes[0];

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
	public OJFDEKIPPJF MJPEJPMACFG
	{
		get
		{
			return mJPEJPMACFG_;
		}
		set
		{
			mJPEJPMACFG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList FNKEBOFAHME
	{
		get
		{
			return fNKEBOFAHME_;
		}
		set
		{
			fNKEBOFAHME_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKAIDKIGEGP AFLJJJFCBIN
	{
		get
		{
			return aFLJJJFCBIN_;
		}
		set
		{
			aFLJJJFCBIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHMJAJGOJPM EDKJMPACHNJ
	{
		get
		{
			return eDKJMPACHNJ_;
		}
		set
		{
			eDKJMPACHNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicSettleScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicSettleScRsp(RogueMagicSettleScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		mJPEJPMACFG_ = ((other.mJPEJPMACFG_ != null) ? other.mJPEJPMACFG_.Clone() : null);
		fNKEBOFAHME_ = ((other.fNKEBOFAHME_ != null) ? other.fNKEBOFAHME_.Clone() : null);
		aFLJJJFCBIN_ = ((other.aFLJJJFCBIN_ != null) ? other.aFLJJJFCBIN_.Clone() : null);
		eDKJMPACHNJ_ = ((other.eDKJMPACHNJ_ != null) ? other.eDKJMPACHNJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicSettleScRsp Clone()
	{
		return new RogueMagicSettleScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueMagicSettleScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueMagicSettleScRsp other)
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
		if (!object.Equals(MJPEJPMACFG, other.MJPEJPMACFG))
		{
			return false;
		}
		if (!object.Equals(FNKEBOFAHME, other.FNKEBOFAHME))
		{
			return false;
		}
		if (!object.Equals(AFLJJJFCBIN, other.AFLJJJFCBIN))
		{
			return false;
		}
		if (!object.Equals(EDKJMPACHNJ, other.EDKJMPACHNJ))
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
		if (mJPEJPMACFG_ != null)
		{
			num ^= MJPEJPMACFG.GetHashCode();
		}
		if (fNKEBOFAHME_ != null)
		{
			num ^= FNKEBOFAHME.GetHashCode();
		}
		if (aFLJJJFCBIN_ != null)
		{
			num ^= AFLJJJFCBIN.GetHashCode();
		}
		if (eDKJMPACHNJ_ != null)
		{
			num ^= EDKJMPACHNJ.GetHashCode();
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
		if (mJPEJPMACFG_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(MJPEJPMACFG);
		}
		if (fNKEBOFAHME_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(FNKEBOFAHME);
		}
		if (aFLJJJFCBIN_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(AFLJJJFCBIN);
		}
		if (eDKJMPACHNJ_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(EDKJMPACHNJ);
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
		if (mJPEJPMACFG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MJPEJPMACFG);
		}
		if (fNKEBOFAHME_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FNKEBOFAHME);
		}
		if (aFLJJJFCBIN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AFLJJJFCBIN);
		}
		if (eDKJMPACHNJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EDKJMPACHNJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueMagicSettleScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.mJPEJPMACFG_ != null)
		{
			if (mJPEJPMACFG_ == null)
			{
				MJPEJPMACFG = new OJFDEKIPPJF();
			}
			MJPEJPMACFG.MergeFrom(other.MJPEJPMACFG);
		}
		if (other.fNKEBOFAHME_ != null)
		{
			if (fNKEBOFAHME_ == null)
			{
				FNKEBOFAHME = new ItemList();
			}
			FNKEBOFAHME.MergeFrom(other.FNKEBOFAHME);
		}
		if (other.aFLJJJFCBIN_ != null)
		{
			if (aFLJJJFCBIN_ == null)
			{
				AFLJJJFCBIN = new JKAIDKIGEGP();
			}
			AFLJJJFCBIN.MergeFrom(other.AFLJJJFCBIN);
		}
		if (other.eDKJMPACHNJ_ != null)
		{
			if (eDKJMPACHNJ_ == null)
			{
				EDKJMPACHNJ = new BHMJAJGOJPM();
			}
			EDKJMPACHNJ.MergeFrom(other.EDKJMPACHNJ);
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
				Retcode = input.ReadUInt32();
				break;
			case 50u:
				if (mJPEJPMACFG_ == null)
				{
					MJPEJPMACFG = new OJFDEKIPPJF();
				}
				input.ReadMessage(MJPEJPMACFG);
				break;
			case 58u:
				if (fNKEBOFAHME_ == null)
				{
					FNKEBOFAHME = new ItemList();
				}
				input.ReadMessage(FNKEBOFAHME);
				break;
			case 90u:
				if (aFLJJJFCBIN_ == null)
				{
					AFLJJJFCBIN = new JKAIDKIGEGP();
				}
				input.ReadMessage(AFLJJJFCBIN);
				break;
			case 106u:
				if (eDKJMPACHNJ_ == null)
				{
					EDKJMPACHNJ = new BHMJAJGOJPM();
				}
				input.ReadMessage(EDKJMPACHNJ);
				break;
			}
		}
	}
}
