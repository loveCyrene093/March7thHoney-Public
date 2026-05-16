using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GNANMEADPBD : IMessage<GNANMEADPBD>, IMessage, IEquatable<GNANMEADPBD>, IDeepCloneable<GNANMEADPBD>, IBufferMessage
{
	private static readonly MessageParser<GNANMEADPBD> _parser = new MessageParser<GNANMEADPBD>(() => new GNANMEADPBD());

	private UnknownFieldSet _unknownFields;

	public const int IPCFOFHLAHGFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_iPCFOFHLAHG_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> iPCFOFHLAHG_ = new RepeatedField<uint>();

	public const int DNNHCNCKJCMFieldNumber = 8;

	private long dNNHCNCKJCM_;

	public const int DNHFPBOPFAJFieldNumber = 10;

	private uint dNHFPBOPFAJ_;

	public const int EndTimeFieldNumber = 12;

	private long endTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GNANMEADPBD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GNANMEADPBDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IPCFOFHLAHG => iPCFOFHLAHG_;

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
	public uint DNHFPBOPFAJ
	{
		get
		{
			return dNHFPBOPFAJ_;
		}
		set
		{
			dNHFPBOPFAJ_ = value;
		}
	}

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
	public GNANMEADPBD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNANMEADPBD(GNANMEADPBD other)
		: this()
	{
		iPCFOFHLAHG_ = other.iPCFOFHLAHG_.Clone();
		dNNHCNCKJCM_ = other.dNNHCNCKJCM_;
		dNHFPBOPFAJ_ = other.dNHFPBOPFAJ_;
		endTime_ = other.endTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNANMEADPBD Clone()
	{
		return new GNANMEADPBD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GNANMEADPBD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GNANMEADPBD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iPCFOFHLAHG_.Equals(other.iPCFOFHLAHG_))
		{
			return false;
		}
		if (DNNHCNCKJCM != other.DNNHCNCKJCM)
		{
			return false;
		}
		if (DNHFPBOPFAJ != other.DNHFPBOPFAJ)
		{
			return false;
		}
		if (EndTime != other.EndTime)
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
		num ^= iPCFOFHLAHG_.GetHashCode();
		if (DNNHCNCKJCM != 0L)
		{
			num ^= DNNHCNCKJCM.GetHashCode();
		}
		if (DNHFPBOPFAJ != 0)
		{
			num ^= DNHFPBOPFAJ.GetHashCode();
		}
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
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
		iPCFOFHLAHG_.WriteTo(ref output, _repeated_iPCFOFHLAHG_codec);
		if (DNNHCNCKJCM != 0L)
		{
			output.WriteRawTag(64);
			output.WriteInt64(DNNHCNCKJCM);
		}
		if (DNHFPBOPFAJ != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(DNHFPBOPFAJ);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(96);
			output.WriteInt64(EndTime);
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
		num += iPCFOFHLAHG_.CalculateSize(_repeated_iPCFOFHLAHG_codec);
		if (DNNHCNCKJCM != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DNNHCNCKJCM);
		}
		if (DNHFPBOPFAJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DNHFPBOPFAJ);
		}
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GNANMEADPBD other)
	{
		if (other != null)
		{
			iPCFOFHLAHG_.Add(other.iPCFOFHLAHG_);
			if (other.DNNHCNCKJCM != 0L)
			{
				DNNHCNCKJCM = other.DNNHCNCKJCM;
			}
			if (other.DNHFPBOPFAJ != 0)
			{
				DNHFPBOPFAJ = other.DNHFPBOPFAJ;
			}
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
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
			case 32u:
			case 34u:
				iPCFOFHLAHG_.AddEntriesFrom(ref input, _repeated_iPCFOFHLAHG_codec);
				break;
			case 64u:
				DNNHCNCKJCM = input.ReadInt64();
				break;
			case 80u:
				DNHFPBOPFAJ = input.ReadUInt32();
				break;
			case 96u:
				EndTime = input.ReadInt64();
				break;
			}
		}
	}
}
