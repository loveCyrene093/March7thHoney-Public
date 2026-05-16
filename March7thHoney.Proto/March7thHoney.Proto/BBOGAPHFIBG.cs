using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BBOGAPHFIBG : IMessage<BBOGAPHFIBG>, IMessage, IEquatable<BBOGAPHFIBG>, IDeepCloneable<BBOGAPHFIBG>, IBufferMessage
{
	private static readonly MessageParser<BBOGAPHFIBG> _parser = new MessageParser<BBOGAPHFIBG>(() => new BBOGAPHFIBG());

	private UnknownFieldSet _unknownFields;

	public const int GIIIGJFMHPOFieldNumber = 3;

	private uint gIIIGJFMHPO_;

	public const int ApplyTimeFieldNumber = 6;

	private long applyTime_;

	public const int EPGIKGCADHMFieldNumber = 10;

	private uint ePGIKGCADHM_;

	public const int DJDEBKPGJDNFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_dJDEBKPGJDN_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> dJDEBKPGJDN_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BBOGAPHFIBG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BBOGAPHFIBGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GIIIGJFMHPO
	{
		get
		{
			return gIIIGJFMHPO_;
		}
		set
		{
			gIIIGJFMHPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ApplyTime
	{
		get
		{
			return applyTime_;
		}
		set
		{
			applyTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EPGIKGCADHM
	{
		get
		{
			return ePGIKGCADHM_;
		}
		set
		{
			ePGIKGCADHM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DJDEBKPGJDN => dJDEBKPGJDN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBOGAPHFIBG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBOGAPHFIBG(BBOGAPHFIBG other)
		: this()
	{
		gIIIGJFMHPO_ = other.gIIIGJFMHPO_;
		applyTime_ = other.applyTime_;
		ePGIKGCADHM_ = other.ePGIKGCADHM_;
		dJDEBKPGJDN_ = other.dJDEBKPGJDN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBOGAPHFIBG Clone()
	{
		return new BBOGAPHFIBG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BBOGAPHFIBG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BBOGAPHFIBG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GIIIGJFMHPO != other.GIIIGJFMHPO)
		{
			return false;
		}
		if (ApplyTime != other.ApplyTime)
		{
			return false;
		}
		if (EPGIKGCADHM != other.EPGIKGCADHM)
		{
			return false;
		}
		if (!dJDEBKPGJDN_.Equals(other.dJDEBKPGJDN_))
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
		if (GIIIGJFMHPO != 0)
		{
			num ^= GIIIGJFMHPO.GetHashCode();
		}
		if (ApplyTime != 0L)
		{
			num ^= ApplyTime.GetHashCode();
		}
		if (EPGIKGCADHM != 0)
		{
			num ^= EPGIKGCADHM.GetHashCode();
		}
		num ^= dJDEBKPGJDN_.GetHashCode();
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
		if (GIIIGJFMHPO != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GIIIGJFMHPO);
		}
		if (ApplyTime != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(ApplyTime);
		}
		if (EPGIKGCADHM != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(EPGIKGCADHM);
		}
		dJDEBKPGJDN_.WriteTo(ref output, _repeated_dJDEBKPGJDN_codec);
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
		if (GIIIGJFMHPO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GIIIGJFMHPO);
		}
		if (ApplyTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ApplyTime);
		}
		if (EPGIKGCADHM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPGIKGCADHM);
		}
		num += dJDEBKPGJDN_.CalculateSize(_repeated_dJDEBKPGJDN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BBOGAPHFIBG other)
	{
		if (other != null)
		{
			if (other.GIIIGJFMHPO != 0)
			{
				GIIIGJFMHPO = other.GIIIGJFMHPO;
			}
			if (other.ApplyTime != 0L)
			{
				ApplyTime = other.ApplyTime;
			}
			if (other.EPGIKGCADHM != 0)
			{
				EPGIKGCADHM = other.EPGIKGCADHM;
			}
			dJDEBKPGJDN_.Add(other.dJDEBKPGJDN_);
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
				GIIIGJFMHPO = input.ReadUInt32();
				break;
			case 48u:
				ApplyTime = input.ReadInt64();
				break;
			case 80u:
				EPGIKGCADHM = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				dJDEBKPGJDN_.AddEntriesFrom(ref input, _repeated_dJDEBKPGJDN_codec);
				break;
			}
		}
	}
}
