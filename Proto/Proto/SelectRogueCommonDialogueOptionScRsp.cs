using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SelectRogueCommonDialogueOptionScRsp : IMessage<SelectRogueCommonDialogueOptionScRsp>, IMessage, IEquatable<SelectRogueCommonDialogueOptionScRsp>, IDeepCloneable<SelectRogueCommonDialogueOptionScRsp>, IBufferMessage
{
	private static readonly MessageParser<SelectRogueCommonDialogueOptionScRsp> _parser = new MessageParser<SelectRogueCommonDialogueOptionScRsp>(() => new SelectRogueCommonDialogueOptionScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MFHLBHFIAGOFieldNumber = 2;

	private bool mFHLBHFIAGO_;

	public const int AMADFJNHMFFFieldNumber = 5;

	private uint aMADFJNHMFF_;

	public const int HOHANPJNANAFieldNumber = 7;

	private uint hOHANPJNANA_;

	public const int DLEGCNJINIEFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_dLEGCNJINIE_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> dLEGCNJINIE_ = new RepeatedField<uint>();

	public const int LFPLCDMNNAPFieldNumber = 12;

	private JIBMJCBNDKK lFPLCDMNNAP_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SelectRogueCommonDialogueOptionScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SelectRogueCommonDialogueOptionScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MFHLBHFIAGO
	{
		get
		{
			return mFHLBHFIAGO_;
		}
		set
		{
			mFHLBHFIAGO_ = value;
		}
	}

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
	public RepeatedField<uint> DLEGCNJINIE => dLEGCNJINIE_;

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
	public SelectRogueCommonDialogueOptionScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectRogueCommonDialogueOptionScRsp(SelectRogueCommonDialogueOptionScRsp other)
		: this()
	{
		mFHLBHFIAGO_ = other.mFHLBHFIAGO_;
		aMADFJNHMFF_ = other.aMADFJNHMFF_;
		hOHANPJNANA_ = other.hOHANPJNANA_;
		dLEGCNJINIE_ = other.dLEGCNJINIE_.Clone();
		lFPLCDMNNAP_ = ((other.lFPLCDMNNAP_ != null) ? other.lFPLCDMNNAP_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectRogueCommonDialogueOptionScRsp Clone()
	{
		return new SelectRogueCommonDialogueOptionScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SelectRogueCommonDialogueOptionScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SelectRogueCommonDialogueOptionScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MFHLBHFIAGO != other.MFHLBHFIAGO)
		{
			return false;
		}
		if (AMADFJNHMFF != other.AMADFJNHMFF)
		{
			return false;
		}
		if (HOHANPJNANA != other.HOHANPJNANA)
		{
			return false;
		}
		if (!dLEGCNJINIE_.Equals(other.dLEGCNJINIE_))
		{
			return false;
		}
		if (!object.Equals(LFPLCDMNNAP, other.LFPLCDMNNAP))
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
		if (MFHLBHFIAGO)
		{
			num ^= MFHLBHFIAGO.GetHashCode();
		}
		if (AMADFJNHMFF != 0)
		{
			num ^= AMADFJNHMFF.GetHashCode();
		}
		if (HOHANPJNANA != 0)
		{
			num ^= HOHANPJNANA.GetHashCode();
		}
		num ^= dLEGCNJINIE_.GetHashCode();
		if (lFPLCDMNNAP_ != null)
		{
			num ^= LFPLCDMNNAP.GetHashCode();
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
		if (MFHLBHFIAGO)
		{
			output.WriteRawTag(16);
			output.WriteBool(MFHLBHFIAGO);
		}
		if (AMADFJNHMFF != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(AMADFJNHMFF);
		}
		if (HOHANPJNANA != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(HOHANPJNANA);
		}
		dLEGCNJINIE_.WriteTo(ref output, _repeated_dLEGCNJINIE_codec);
		if (lFPLCDMNNAP_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(LFPLCDMNNAP);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
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
		if (MFHLBHFIAGO)
		{
			num += 2;
		}
		if (AMADFJNHMFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AMADFJNHMFF);
		}
		if (HOHANPJNANA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HOHANPJNANA);
		}
		num += dLEGCNJINIE_.CalculateSize(_repeated_dLEGCNJINIE_codec);
		if (lFPLCDMNNAP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LFPLCDMNNAP);
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
	public void MergeFrom(SelectRogueCommonDialogueOptionScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MFHLBHFIAGO)
		{
			MFHLBHFIAGO = other.MFHLBHFIAGO;
		}
		if (other.AMADFJNHMFF != 0)
		{
			AMADFJNHMFF = other.AMADFJNHMFF;
		}
		if (other.HOHANPJNANA != 0)
		{
			HOHANPJNANA = other.HOHANPJNANA;
		}
		dLEGCNJINIE_.Add(other.dLEGCNJINIE_);
		if (other.lFPLCDMNNAP_ != null)
		{
			if (lFPLCDMNNAP_ == null)
			{
				LFPLCDMNNAP = new JIBMJCBNDKK();
			}
			LFPLCDMNNAP.MergeFrom(other.LFPLCDMNNAP);
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
			case 16u:
				MFHLBHFIAGO = input.ReadBool();
				break;
			case 40u:
				AMADFJNHMFF = input.ReadUInt32();
				break;
			case 56u:
				HOHANPJNANA = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				dLEGCNJINIE_.AddEntriesFrom(ref input, _repeated_dLEGCNJINIE_codec);
				break;
			case 98u:
				if (lFPLCDMNNAP_ == null)
				{
					LFPLCDMNNAP = new JIBMJCBNDKK();
				}
				input.ReadMessage(LFPLCDMNNAP);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
