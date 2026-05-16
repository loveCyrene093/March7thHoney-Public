using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournConfirmSettleScRsp : IMessage<RogueTournConfirmSettleScRsp>, IMessage, IEquatable<RogueTournConfirmSettleScRsp>, IDeepCloneable<RogueTournConfirmSettleScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueTournConfirmSettleScRsp> _parser = new MessageParser<RogueTournConfirmSettleScRsp>(() => new RogueTournConfirmSettleScRsp());

	private UnknownFieldSet _unknownFields;

	public const int FNKEBOFAHMEFieldNumber = 1;

	private ItemList fNKEBOFAHME_;

	public const int MNADHGINDPIFieldNumber = 3;

	private ItemList mNADHGINDPI_;

	public const int GFMNOMPDINDFieldNumber = 4;

	private OJKAHCEKDGN gFMNOMPDIND_;

	public const int AFLJJJFCBINFieldNumber = 6;

	private BFEIPELFCDF aFLJJJFCBIN_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournConfirmSettleScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournConfirmSettleScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public ItemList MNADHGINDPI
	{
		get
		{
			return mNADHGINDPI_;
		}
		set
		{
			mNADHGINDPI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJKAHCEKDGN GFMNOMPDIND
	{
		get
		{
			return gFMNOMPDIND_;
		}
		set
		{
			gFMNOMPDIND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFEIPELFCDF AFLJJJFCBIN
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
	public RogueTournConfirmSettleScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournConfirmSettleScRsp(RogueTournConfirmSettleScRsp other)
		: this()
	{
		fNKEBOFAHME_ = ((other.fNKEBOFAHME_ != null) ? other.fNKEBOFAHME_.Clone() : null);
		mNADHGINDPI_ = ((other.mNADHGINDPI_ != null) ? other.mNADHGINDPI_.Clone() : null);
		gFMNOMPDIND_ = ((other.gFMNOMPDIND_ != null) ? other.gFMNOMPDIND_.Clone() : null);
		aFLJJJFCBIN_ = ((other.aFLJJJFCBIN_ != null) ? other.aFLJJJFCBIN_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournConfirmSettleScRsp Clone()
	{
		return new RogueTournConfirmSettleScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournConfirmSettleScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournConfirmSettleScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FNKEBOFAHME, other.FNKEBOFAHME))
		{
			return false;
		}
		if (!object.Equals(MNADHGINDPI, other.MNADHGINDPI))
		{
			return false;
		}
		if (!object.Equals(GFMNOMPDIND, other.GFMNOMPDIND))
		{
			return false;
		}
		if (!object.Equals(AFLJJJFCBIN, other.AFLJJJFCBIN))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (fNKEBOFAHME_ != null)
		{
			num ^= FNKEBOFAHME.GetHashCode();
		}
		if (mNADHGINDPI_ != null)
		{
			num ^= MNADHGINDPI.GetHashCode();
		}
		if (gFMNOMPDIND_ != null)
		{
			num ^= GFMNOMPDIND.GetHashCode();
		}
		if (aFLJJJFCBIN_ != null)
		{
			num ^= AFLJJJFCBIN.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (fNKEBOFAHME_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(FNKEBOFAHME);
		}
		if (mNADHGINDPI_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MNADHGINDPI);
		}
		if (gFMNOMPDIND_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(GFMNOMPDIND);
		}
		if (aFLJJJFCBIN_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(AFLJJJFCBIN);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
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
		if (fNKEBOFAHME_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FNKEBOFAHME);
		}
		if (mNADHGINDPI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MNADHGINDPI);
		}
		if (gFMNOMPDIND_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GFMNOMPDIND);
		}
		if (aFLJJJFCBIN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AFLJJJFCBIN);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournConfirmSettleScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fNKEBOFAHME_ != null)
		{
			if (fNKEBOFAHME_ == null)
			{
				FNKEBOFAHME = new ItemList();
			}
			FNKEBOFAHME.MergeFrom(other.FNKEBOFAHME);
		}
		if (other.mNADHGINDPI_ != null)
		{
			if (mNADHGINDPI_ == null)
			{
				MNADHGINDPI = new ItemList();
			}
			MNADHGINDPI.MergeFrom(other.MNADHGINDPI);
		}
		if (other.gFMNOMPDIND_ != null)
		{
			if (gFMNOMPDIND_ == null)
			{
				GFMNOMPDIND = new OJKAHCEKDGN();
			}
			GFMNOMPDIND.MergeFrom(other.GFMNOMPDIND);
		}
		if (other.aFLJJJFCBIN_ != null)
		{
			if (aFLJJJFCBIN_ == null)
			{
				AFLJJJFCBIN = new BFEIPELFCDF();
			}
			AFLJJJFCBIN.MergeFrom(other.AFLJJJFCBIN);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 10u:
				if (fNKEBOFAHME_ == null)
				{
					FNKEBOFAHME = new ItemList();
				}
				input.ReadMessage(FNKEBOFAHME);
				break;
			case 26u:
				if (mNADHGINDPI_ == null)
				{
					MNADHGINDPI = new ItemList();
				}
				input.ReadMessage(MNADHGINDPI);
				break;
			case 34u:
				if (gFMNOMPDIND_ == null)
				{
					GFMNOMPDIND = new OJKAHCEKDGN();
				}
				input.ReadMessage(GFMNOMPDIND);
				break;
			case 50u:
				if (aFLJJJFCBIN_ == null)
				{
					AFLJJJFCBIN = new BFEIPELFCDF();
				}
				input.ReadMessage(AFLJJJFCBIN);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
