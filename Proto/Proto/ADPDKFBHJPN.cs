using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ADPDKFBHJPN : IMessage<ADPDKFBHJPN>, IMessage, IEquatable<ADPDKFBHJPN>, IDeepCloneable<ADPDKFBHJPN>, IBufferMessage
{
	private static readonly MessageParser<ADPDKFBHJPN> _parser = new MessageParser<ADPDKFBHJPN>(() => new ADPDKFBHJPN());

	private UnknownFieldSet _unknownFields;

	public const int DGFNOAHLCMKFieldNumber = 7;

	private uint dGFNOAHLCMK_;

	public const int StatusFieldNumber = 8;

	private LFGMADFAKHK status_;

	public const int ProgressFieldNumber = 12;

	private uint progress_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ADPDKFBHJPN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ADPDKFBHJPNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DGFNOAHLCMK
	{
		get
		{
			return dGFNOAHLCMK_;
		}
		set
		{
			dGFNOAHLCMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFGMADFAKHK Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADPDKFBHJPN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADPDKFBHJPN(ADPDKFBHJPN other)
		: this()
	{
		dGFNOAHLCMK_ = other.dGFNOAHLCMK_;
		status_ = other.status_;
		progress_ = other.progress_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADPDKFBHJPN Clone()
	{
		return new ADPDKFBHJPN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ADPDKFBHJPN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ADPDKFBHJPN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DGFNOAHLCMK != other.DGFNOAHLCMK)
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (Progress != other.Progress)
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
		if (DGFNOAHLCMK != 0)
		{
			num ^= DGFNOAHLCMK.GetHashCode();
		}
		if (Status != LFGMADFAKHK.Pcpdhelpkem)
		{
			num ^= Status.GetHashCode();
		}
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
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
		if (DGFNOAHLCMK != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(DGFNOAHLCMK);
		}
		if (Status != LFGMADFAKHK.Pcpdhelpkem)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)Status);
		}
		if (Progress != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Progress);
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
		if (DGFNOAHLCMK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DGFNOAHLCMK);
		}
		if (Status != LFGMADFAKHK.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ADPDKFBHJPN other)
	{
		if (other != null)
		{
			if (other.DGFNOAHLCMK != 0)
			{
				DGFNOAHLCMK = other.DGFNOAHLCMK;
			}
			if (other.Status != LFGMADFAKHK.Pcpdhelpkem)
			{
				Status = other.Status;
			}
			if (other.Progress != 0)
			{
				Progress = other.Progress;
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
			case 56u:
				DGFNOAHLCMK = input.ReadUInt32();
				break;
			case 64u:
				Status = (LFGMADFAKHK)input.ReadEnum();
				break;
			case 96u:
				Progress = input.ReadUInt32();
				break;
			}
		}
	}
}
