using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HBMNFGPKECH : IMessage<HBMNFGPKECH>, IMessage, IEquatable<HBMNFGPKECH>, IDeepCloneable<HBMNFGPKECH>, IBufferMessage
{
	private static readonly MessageParser<HBMNFGPKECH> _parser = new MessageParser<HBMNFGPKECH>(() => new HBMNFGPKECH());

	private UnknownFieldSet _unknownFields;

	public const int DJDEBKPGJDNFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_dJDEBKPGJDN_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> dJDEBKPGJDN_ = new RepeatedField<uint>();

	public const int CDCBFHFJGMDFieldNumber = 6;

	private uint cDCBFHFJGMD_;

	public const int TimeFieldNumber = 7;

	private long time_;

	public const int JFHMCDFDABIFieldNumber = 8;

	private bool jFHMCDFDABI_;

	public const int PHALKDHHPPBFieldNumber = 13;

	private ulong pHALKDHHPPB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HBMNFGPKECH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HBMNFGPKECHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DJDEBKPGJDN => dJDEBKPGJDN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CDCBFHFJGMD
	{
		get
		{
			return cDCBFHFJGMD_;
		}
		set
		{
			cDCBFHFJGMD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JFHMCDFDABI
	{
		get
		{
			return jFHMCDFDABI_;
		}
		set
		{
			jFHMCDFDABI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong PHALKDHHPPB
	{
		get
		{
			return pHALKDHHPPB_;
		}
		set
		{
			pHALKDHHPPB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBMNFGPKECH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBMNFGPKECH(HBMNFGPKECH other)
		: this()
	{
		dJDEBKPGJDN_ = other.dJDEBKPGJDN_.Clone();
		cDCBFHFJGMD_ = other.cDCBFHFJGMD_;
		time_ = other.time_;
		jFHMCDFDABI_ = other.jFHMCDFDABI_;
		pHALKDHHPPB_ = other.pHALKDHHPPB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBMNFGPKECH Clone()
	{
		return new HBMNFGPKECH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HBMNFGPKECH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HBMNFGPKECH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dJDEBKPGJDN_.Equals(other.dJDEBKPGJDN_))
		{
			return false;
		}
		if (CDCBFHFJGMD != other.CDCBFHFJGMD)
		{
			return false;
		}
		if (Time != other.Time)
		{
			return false;
		}
		if (JFHMCDFDABI != other.JFHMCDFDABI)
		{
			return false;
		}
		if (PHALKDHHPPB != other.PHALKDHHPPB)
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
		num ^= dJDEBKPGJDN_.GetHashCode();
		if (CDCBFHFJGMD != 0)
		{
			num ^= CDCBFHFJGMD.GetHashCode();
		}
		if (Time != 0L)
		{
			num ^= Time.GetHashCode();
		}
		if (JFHMCDFDABI)
		{
			num ^= JFHMCDFDABI.GetHashCode();
		}
		if (PHALKDHHPPB != 0L)
		{
			num ^= PHALKDHHPPB.GetHashCode();
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
		dJDEBKPGJDN_.WriteTo(ref output, _repeated_dJDEBKPGJDN_codec);
		if (CDCBFHFJGMD != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(CDCBFHFJGMD);
		}
		if (Time != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(Time);
		}
		if (JFHMCDFDABI)
		{
			output.WriteRawTag(64);
			output.WriteBool(JFHMCDFDABI);
		}
		if (PHALKDHHPPB != 0L)
		{
			output.WriteRawTag(104);
			output.WriteUInt64(PHALKDHHPPB);
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
		num += dJDEBKPGJDN_.CalculateSize(_repeated_dJDEBKPGJDN_codec);
		if (CDCBFHFJGMD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CDCBFHFJGMD);
		}
		if (Time != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Time);
		}
		if (JFHMCDFDABI)
		{
			num += 2;
		}
		if (PHALKDHHPPB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PHALKDHHPPB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HBMNFGPKECH other)
	{
		if (other != null)
		{
			dJDEBKPGJDN_.Add(other.dJDEBKPGJDN_);
			if (other.CDCBFHFJGMD != 0)
			{
				CDCBFHFJGMD = other.CDCBFHFJGMD;
			}
			if (other.Time != 0L)
			{
				Time = other.Time;
			}
			if (other.JFHMCDFDABI)
			{
				JFHMCDFDABI = other.JFHMCDFDABI;
			}
			if (other.PHALKDHHPPB != 0L)
			{
				PHALKDHHPPB = other.PHALKDHHPPB;
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
			case 10u:
				dJDEBKPGJDN_.AddEntriesFrom(ref input, _repeated_dJDEBKPGJDN_codec);
				break;
			case 48u:
				CDCBFHFJGMD = input.ReadUInt32();
				break;
			case 56u:
				Time = input.ReadInt64();
				break;
			case 64u:
				JFHMCDFDABI = input.ReadBool();
				break;
			case 104u:
				PHALKDHHPPB = input.ReadUInt64();
				break;
			}
		}
	}
}
