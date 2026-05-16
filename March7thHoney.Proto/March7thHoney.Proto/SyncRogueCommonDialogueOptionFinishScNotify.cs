using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncRogueCommonDialogueOptionFinishScNotify : IMessage<SyncRogueCommonDialogueOptionFinishScNotify>, IMessage, IEquatable<SyncRogueCommonDialogueOptionFinishScNotify>, IDeepCloneable<SyncRogueCommonDialogueOptionFinishScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncRogueCommonDialogueOptionFinishScNotify> _parser = new MessageParser<SyncRogueCommonDialogueOptionFinishScNotify>(() => new SyncRogueCommonDialogueOptionFinishScNotify());

	private UnknownFieldSet _unknownFields;

	public const int AMADFJNHMFFFieldNumber = 6;

	private uint aMADFJNHMFF_;

	public const int KAMMBMPFAECFieldNumber = 10;

	private GBHHOMHNLKD kAMMBMPFAEC_;

	public const int LFPLCDMNNAPFieldNumber = 11;

	private JIBMJCBNDKK lFPLCDMNNAP_;

	public const int HOHANPJNANAFieldNumber = 14;

	private uint hOHANPJNANA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncRogueCommonDialogueOptionFinishScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncRogueCommonDialogueOptionFinishScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AMADFJNHMFF
	{
		get
		{
			return aMADFJNHMFF_;
		}
		set
		{
			aMADFJNHMFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBHHOMHNLKD KAMMBMPFAEC
	{
		get
		{
			return kAMMBMPFAEC_;
		}
		set
		{
			kAMMBMPFAEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIBMJCBNDKK LFPLCDMNNAP
	{
		get
		{
			return lFPLCDMNNAP_;
		}
		set
		{
			lFPLCDMNNAP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HOHANPJNANA
	{
		get
		{
			return hOHANPJNANA_;
		}
		set
		{
			hOHANPJNANA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueCommonDialogueOptionFinishScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueCommonDialogueOptionFinishScNotify(SyncRogueCommonDialogueOptionFinishScNotify other)
		: this()
	{
		aMADFJNHMFF_ = other.aMADFJNHMFF_;
		kAMMBMPFAEC_ = ((other.kAMMBMPFAEC_ != null) ? other.kAMMBMPFAEC_.Clone() : null);
		lFPLCDMNNAP_ = ((other.lFPLCDMNNAP_ != null) ? other.lFPLCDMNNAP_.Clone() : null);
		hOHANPJNANA_ = other.hOHANPJNANA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueCommonDialogueOptionFinishScNotify Clone()
	{
		return new SyncRogueCommonDialogueOptionFinishScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncRogueCommonDialogueOptionFinishScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncRogueCommonDialogueOptionFinishScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AMADFJNHMFF != other.AMADFJNHMFF)
		{
			return false;
		}
		if (!object.Equals(KAMMBMPFAEC, other.KAMMBMPFAEC))
		{
			return false;
		}
		if (!object.Equals(LFPLCDMNNAP, other.LFPLCDMNNAP))
		{
			return false;
		}
		if (HOHANPJNANA != other.HOHANPJNANA)
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
		if (AMADFJNHMFF != 0)
		{
			num ^= AMADFJNHMFF.GetHashCode();
		}
		if (kAMMBMPFAEC_ != null)
		{
			num ^= KAMMBMPFAEC.GetHashCode();
		}
		if (lFPLCDMNNAP_ != null)
		{
			num ^= LFPLCDMNNAP.GetHashCode();
		}
		if (HOHANPJNANA != 0)
		{
			num ^= HOHANPJNANA.GetHashCode();
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
		if (AMADFJNHMFF != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(AMADFJNHMFF);
		}
		if (kAMMBMPFAEC_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(KAMMBMPFAEC);
		}
		if (lFPLCDMNNAP_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(LFPLCDMNNAP);
		}
		if (HOHANPJNANA != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(HOHANPJNANA);
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
		if (AMADFJNHMFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AMADFJNHMFF);
		}
		if (kAMMBMPFAEC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KAMMBMPFAEC);
		}
		if (lFPLCDMNNAP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LFPLCDMNNAP);
		}
		if (HOHANPJNANA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HOHANPJNANA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncRogueCommonDialogueOptionFinishScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.AMADFJNHMFF != 0)
		{
			AMADFJNHMFF = other.AMADFJNHMFF;
		}
		if (other.kAMMBMPFAEC_ != null)
		{
			if (kAMMBMPFAEC_ == null)
			{
				KAMMBMPFAEC = new GBHHOMHNLKD();
			}
			KAMMBMPFAEC.MergeFrom(other.KAMMBMPFAEC);
		}
		if (other.lFPLCDMNNAP_ != null)
		{
			if (lFPLCDMNNAP_ == null)
			{
				LFPLCDMNNAP = new JIBMJCBNDKK();
			}
			LFPLCDMNNAP.MergeFrom(other.LFPLCDMNNAP);
		}
		if (other.HOHANPJNANA != 0)
		{
			HOHANPJNANA = other.HOHANPJNANA;
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
			case 48u:
				AMADFJNHMFF = input.ReadUInt32();
				break;
			case 82u:
				if (kAMMBMPFAEC_ == null)
				{
					KAMMBMPFAEC = new GBHHOMHNLKD();
				}
				input.ReadMessage(KAMMBMPFAEC);
				break;
			case 90u:
				if (lFPLCDMNNAP_ == null)
				{
					LFPLCDMNNAP = new JIBMJCBNDKK();
				}
				input.ReadMessage(LFPLCDMNNAP);
				break;
			case 112u:
				HOHANPJNANA = input.ReadUInt32();
				break;
			}
		}
	}
}
