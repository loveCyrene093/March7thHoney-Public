using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ABIPCNKGFNI : IMessage<ABIPCNKGFNI>, IMessage, IEquatable<ABIPCNKGFNI>, IDeepCloneable<ABIPCNKGFNI>, IBufferMessage
{
	private static readonly MessageParser<ABIPCNKGFNI> _parser = new MessageParser<ABIPCNKGFNI>(() => new ABIPCNKGFNI());

	private UnknownFieldSet _unknownFields;

	public const int FLHLJMEMIHLFieldNumber = 1;

	private static readonly FieldCodec<PPPFOMBLOIF> _repeated_fLHLJMEMIHL_codec = FieldCodec.ForMessage(10u, PPPFOMBLOIF.Parser);

	private readonly RepeatedField<PPPFOMBLOIF> fLHLJMEMIHL_ = new RepeatedField<PPPFOMBLOIF>();

	public const int EndTimeFieldNumber = 4;

	private long endTime_;

	public const int GiftTypeFieldNumber = 8;

	private uint giftType_;

	public const int DNNHCNCKJCMFieldNumber = 11;

	private long dNNHCNCKJCM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ABIPCNKGFNI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ABIPCNKGFNIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PPPFOMBLOIF> FLHLJMEMIHL => fLHLJMEMIHL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EndTime
	{
		get
		{
			return endTime_;
		}
		set
		{
			endTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GiftType
	{
		get
		{
			return giftType_;
		}
		set
		{
			giftType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DNNHCNCKJCM
	{
		get
		{
			return dNNHCNCKJCM_;
		}
		set
		{
			dNNHCNCKJCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ABIPCNKGFNI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ABIPCNKGFNI(ABIPCNKGFNI other)
		: this()
	{
		fLHLJMEMIHL_ = other.fLHLJMEMIHL_.Clone();
		endTime_ = other.endTime_;
		giftType_ = other.giftType_;
		dNNHCNCKJCM_ = other.dNNHCNCKJCM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ABIPCNKGFNI Clone()
	{
		return new ABIPCNKGFNI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ABIPCNKGFNI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ABIPCNKGFNI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fLHLJMEMIHL_.Equals(other.fLHLJMEMIHL_))
		{
			return false;
		}
		if (EndTime != other.EndTime)
		{
			return false;
		}
		if (GiftType != other.GiftType)
		{
			return false;
		}
		if (DNNHCNCKJCM != other.DNNHCNCKJCM)
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
		num ^= fLHLJMEMIHL_.GetHashCode();
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		if (GiftType != 0)
		{
			num ^= GiftType.GetHashCode();
		}
		if (DNNHCNCKJCM != 0L)
		{
			num ^= DNNHCNCKJCM.GetHashCode();
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
		fLHLJMEMIHL_.WriteTo(ref output, _repeated_fLHLJMEMIHL_codec);
		if (EndTime != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(EndTime);
		}
		if (GiftType != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(GiftType);
		}
		if (DNNHCNCKJCM != 0L)
		{
			output.WriteRawTag(88);
			output.WriteInt64(DNNHCNCKJCM);
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
		num += fLHLJMEMIHL_.CalculateSize(_repeated_fLHLJMEMIHL_codec);
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (GiftType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GiftType);
		}
		if (DNNHCNCKJCM != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DNNHCNCKJCM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ABIPCNKGFNI other)
	{
		if (other != null)
		{
			fLHLJMEMIHL_.Add(other.fLHLJMEMIHL_);
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
			}
			if (other.GiftType != 0)
			{
				GiftType = other.GiftType;
			}
			if (other.DNNHCNCKJCM != 0L)
			{
				DNNHCNCKJCM = other.DNNHCNCKJCM;
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
			case 10u:
				fLHLJMEMIHL_.AddEntriesFrom(ref input, _repeated_fLHLJMEMIHL_codec);
				break;
			case 32u:
				EndTime = input.ReadInt64();
				break;
			case 64u:
				GiftType = input.ReadUInt32();
				break;
			case 88u:
				DNNHCNCKJCM = input.ReadInt64();
				break;
			}
		}
	}
}
