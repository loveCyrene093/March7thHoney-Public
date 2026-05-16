using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ActivityRaidPlacingGameScRsp : IMessage<ActivityRaidPlacingGameScRsp>, IMessage, IEquatable<ActivityRaidPlacingGameScRsp>, IDeepCloneable<ActivityRaidPlacingGameScRsp>, IBufferMessage
{
	public enum DLOMKFLEEICOneofCase
	{
		None = 0,
		OBPNDKPPFGG = 8,
		MFMHHAPPPJJ = 10
	}

	private static readonly MessageParser<ActivityRaidPlacingGameScRsp> _parser = new MessageParser<ActivityRaidPlacingGameScRsp>(() => new ActivityRaidPlacingGameScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int OBPNDKPPFGGFieldNumber = 8;

	public const int MFMHHAPPPJJFieldNumber = 10;

	private object dLOMKFLEEIC_;

	private DLOMKFLEEICOneofCase dLOMKFLEEICCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ActivityRaidPlacingGameScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ActivityRaidPlacingGameScRspReflection.Descriptor.MessageTypes[0];

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
	public uint OBPNDKPPFGG
	{
		get
		{
			if (!HasOBPNDKPPFGG)
			{
				return 0u;
			}
			return (uint)dLOMKFLEEIC_;
		}
		set
		{
			dLOMKFLEEIC_ = value;
			dLOMKFLEEICCase_ = DLOMKFLEEICOneofCase.OBPNDKPPFGG;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasOBPNDKPPFGG => dLOMKFLEEICCase_ == DLOMKFLEEICOneofCase.OBPNDKPPFGG;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MFMHHAPPPJJ
	{
		get
		{
			if (!HasMFMHHAPPPJJ)
			{
				return 0u;
			}
			return (uint)dLOMKFLEEIC_;
		}
		set
		{
			dLOMKFLEEIC_ = value;
			dLOMKFLEEICCase_ = DLOMKFLEEICOneofCase.MFMHHAPPPJJ;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMFMHHAPPPJJ => dLOMKFLEEICCase_ == DLOMKFLEEICOneofCase.MFMHHAPPPJJ;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLOMKFLEEICOneofCase DLOMKFLEEICCase => dLOMKFLEEICCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivityRaidPlacingGameScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivityRaidPlacingGameScRsp(ActivityRaidPlacingGameScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		switch (other.DLOMKFLEEICCase)
		{
		case DLOMKFLEEICOneofCase.OBPNDKPPFGG:
			OBPNDKPPFGG = other.OBPNDKPPFGG;
			break;
		case DLOMKFLEEICOneofCase.MFMHHAPPPJJ:
			MFMHHAPPPJJ = other.MFMHHAPPPJJ;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivityRaidPlacingGameScRsp Clone()
	{
		return new ActivityRaidPlacingGameScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearOBPNDKPPFGG()
	{
		if (HasOBPNDKPPFGG)
		{
			ClearDLOMKFLEEIC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearMFMHHAPPPJJ()
	{
		if (HasMFMHHAPPPJJ)
		{
			ClearDLOMKFLEEIC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearDLOMKFLEEIC()
	{
		dLOMKFLEEICCase_ = DLOMKFLEEICOneofCase.None;
		dLOMKFLEEIC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ActivityRaidPlacingGameScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ActivityRaidPlacingGameScRsp other)
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
		if (OBPNDKPPFGG != other.OBPNDKPPFGG)
		{
			return false;
		}
		if (MFMHHAPPPJJ != other.MFMHHAPPPJJ)
		{
			return false;
		}
		if (DLOMKFLEEICCase != other.DLOMKFLEEICCase)
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
		if (HasOBPNDKPPFGG)
		{
			num ^= OBPNDKPPFGG.GetHashCode();
		}
		if (HasMFMHHAPPPJJ)
		{
			num ^= MFMHHAPPPJJ.GetHashCode();
		}
		num ^= (int)dLOMKFLEEICCase_;
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
		if (HasOBPNDKPPFGG)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(OBPNDKPPFGG);
		}
		if (HasMFMHHAPPPJJ)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(MFMHHAPPPJJ);
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
		if (HasOBPNDKPPFGG)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OBPNDKPPFGG);
		}
		if (HasMFMHHAPPPJJ)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MFMHHAPPPJJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ActivityRaidPlacingGameScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			switch (other.DLOMKFLEEICCase)
			{
			case DLOMKFLEEICOneofCase.OBPNDKPPFGG:
				OBPNDKPPFGG = other.OBPNDKPPFGG;
				break;
			case DLOMKFLEEICOneofCase.MFMHHAPPPJJ:
				MFMHHAPPPJJ = other.MFMHHAPPPJJ;
				break;
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
			case 64u:
				OBPNDKPPFGG = input.ReadUInt32();
				break;
			case 80u:
				MFMHHAPPPJJ = input.ReadUInt32();
				break;
			}
		}
	}
}
