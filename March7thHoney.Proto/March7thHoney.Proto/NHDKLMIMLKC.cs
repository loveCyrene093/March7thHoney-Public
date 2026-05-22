using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NHDKLMIMLKC : IMessage<NHDKLMIMLKC>, IMessage, IEquatable<NHDKLMIMLKC>, IDeepCloneable<NHDKLMIMLKC>, IBufferMessage
{
	private static readonly MessageParser<NHDKLMIMLKC> _parser = new MessageParser<NHDKLMIMLKC>(() => new NHDKLMIMLKC());

	private UnknownFieldSet _unknownFields;

	public const int PGMJPLLNIAKFieldNumber = 3;

	private uint pGMJPLLNIAK_;

	public const int EndTimeFieldNumber = 5;

	private long endTime_;

	public const int DNNHCNCKJCMFieldNumber = 9;

	private long dNNHCNCKJCM_;

	public const int MIDKMIIDPHFFieldNumber = 11;

	private bool mIDKMIIDPHF_;

	public const int IPCFOFHLAHGFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_iPCFOFHLAHG_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> iPCFOFHLAHG_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NHDKLMIMLKC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NHDKLMIMLKCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PGMJPLLNIAK
	{
		get
		{
			return pGMJPLLNIAK_;
		}
		set
		{
			pGMJPLLNIAK_ = value;
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
	public bool MIDKMIIDPHF
	{
		get
		{
			return mIDKMIIDPHF_;
		}
		set
		{
			mIDKMIIDPHF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IPCFOFHLAHG => iPCFOFHLAHG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHDKLMIMLKC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHDKLMIMLKC(NHDKLMIMLKC other)
		: this()
	{
		pGMJPLLNIAK_ = other.pGMJPLLNIAK_;
		endTime_ = other.endTime_;
		dNNHCNCKJCM_ = other.dNNHCNCKJCM_;
		mIDKMIIDPHF_ = other.mIDKMIIDPHF_;
		iPCFOFHLAHG_ = other.iPCFOFHLAHG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHDKLMIMLKC Clone()
	{
		return new NHDKLMIMLKC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NHDKLMIMLKC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NHDKLMIMLKC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PGMJPLLNIAK != other.PGMJPLLNIAK)
		{
			return false;
		}
		if (EndTime != other.EndTime)
		{
			return false;
		}
		if (DNNHCNCKJCM != other.DNNHCNCKJCM)
		{
			return false;
		}
		if (MIDKMIIDPHF != other.MIDKMIIDPHF)
		{
			return false;
		}
		if (!iPCFOFHLAHG_.Equals(other.iPCFOFHLAHG_))
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
		if (PGMJPLLNIAK != 0)
		{
			num ^= PGMJPLLNIAK.GetHashCode();
		}
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		if (DNNHCNCKJCM != 0L)
		{
			num ^= DNNHCNCKJCM.GetHashCode();
		}
		if (MIDKMIIDPHF)
		{
			num ^= MIDKMIIDPHF.GetHashCode();
		}
		num ^= iPCFOFHLAHG_.GetHashCode();
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
		if (PGMJPLLNIAK != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PGMJPLLNIAK);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(40);
			output.WriteInt64(EndTime);
		}
		if (DNNHCNCKJCM != 0L)
		{
			output.WriteRawTag(72);
			output.WriteInt64(DNNHCNCKJCM);
		}
		if (MIDKMIIDPHF)
		{
			output.WriteRawTag(88);
			output.WriteBool(MIDKMIIDPHF);
		}
		iPCFOFHLAHG_.WriteTo(ref output, _repeated_iPCFOFHLAHG_codec);
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
		if (PGMJPLLNIAK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PGMJPLLNIAK);
		}
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (DNNHCNCKJCM != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DNNHCNCKJCM);
		}
		if (MIDKMIIDPHF)
		{
			num += 2;
		}
		num += iPCFOFHLAHG_.CalculateSize(_repeated_iPCFOFHLAHG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NHDKLMIMLKC other)
	{
		if (other != null)
		{
			if (other.PGMJPLLNIAK != 0)
			{
				PGMJPLLNIAK = other.PGMJPLLNIAK;
			}
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
			}
			if (other.DNNHCNCKJCM != 0L)
			{
				DNNHCNCKJCM = other.DNNHCNCKJCM;
			}
			if (other.MIDKMIIDPHF)
			{
				MIDKMIIDPHF = other.MIDKMIIDPHF;
			}
			iPCFOFHLAHG_.Add(other.iPCFOFHLAHG_);
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
			case 24u:
				PGMJPLLNIAK = input.ReadUInt32();
				break;
			case 40u:
				EndTime = input.ReadInt64();
				break;
			case 72u:
				DNNHCNCKJCM = input.ReadInt64();
				break;
			case 88u:
				MIDKMIIDPHF = input.ReadBool();
				break;
			case 96u:
			case 98u:
				iPCFOFHLAHG_.AddEntriesFrom(ref input, _repeated_iPCFOFHLAHG_codec);
				break;
			}
		}
	}
}
