using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HHKHKGDAMNB : IMessage<HHKHKGDAMNB>, IMessage, IEquatable<HHKHKGDAMNB>, IDeepCloneable<HHKHKGDAMNB>, IBufferMessage
{
	private static readonly MessageParser<HHKHKGDAMNB> _parser = new MessageParser<HHKHKGDAMNB>(() => new HHKHKGDAMNB());

	private UnknownFieldSet _unknownFields;

	public const int SourceFieldNumber = 3;

	private uint source_;

	public const int GIIIGJFMHPOFieldNumber = 7;

	private uint gIIIGJFMHPO_;

	public const int EPGIKGCADHMFieldNumber = 11;

	private uint ePGIKGCADHM_;

	public const int DJDEBKPGJDNFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_dJDEBKPGJDN_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> dJDEBKPGJDN_ = new RepeatedField<uint>();

	public const int TimeFieldNumber = 14;

	private long time_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HHKHKGDAMNB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HHKHKGDAMNBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
		}
	}

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
	public HHKHKGDAMNB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHKHKGDAMNB(HHKHKGDAMNB other)
		: this()
	{
		source_ = other.source_;
		gIIIGJFMHPO_ = other.gIIIGJFMHPO_;
		ePGIKGCADHM_ = other.ePGIKGCADHM_;
		dJDEBKPGJDN_ = other.dJDEBKPGJDN_.Clone();
		time_ = other.time_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHKHKGDAMNB Clone()
	{
		return new HHKHKGDAMNB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HHKHKGDAMNB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HHKHKGDAMNB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Source != other.Source)
		{
			return false;
		}
		if (GIIIGJFMHPO != other.GIIIGJFMHPO)
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
		if (Time != other.Time)
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
		if (Source != 0)
		{
			num ^= Source.GetHashCode();
		}
		if (GIIIGJFMHPO != 0)
		{
			num ^= GIIIGJFMHPO.GetHashCode();
		}
		if (EPGIKGCADHM != 0)
		{
			num ^= EPGIKGCADHM.GetHashCode();
		}
		num ^= dJDEBKPGJDN_.GetHashCode();
		if (Time != 0L)
		{
			num ^= Time.GetHashCode();
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
		if (Source != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Source);
		}
		if (GIIIGJFMHPO != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(GIIIGJFMHPO);
		}
		if (EPGIKGCADHM != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(EPGIKGCADHM);
		}
		dJDEBKPGJDN_.WriteTo(ref output, _repeated_dJDEBKPGJDN_codec);
		if (Time != 0L)
		{
			output.WriteRawTag(112);
			output.WriteInt64(Time);
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
		if (Source != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Source);
		}
		if (GIIIGJFMHPO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GIIIGJFMHPO);
		}
		if (EPGIKGCADHM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPGIKGCADHM);
		}
		num += dJDEBKPGJDN_.CalculateSize(_repeated_dJDEBKPGJDN_codec);
		if (Time != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Time);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HHKHKGDAMNB other)
	{
		if (other != null)
		{
			if (other.Source != 0)
			{
				Source = other.Source;
			}
			if (other.GIIIGJFMHPO != 0)
			{
				GIIIGJFMHPO = other.GIIIGJFMHPO;
			}
			if (other.EPGIKGCADHM != 0)
			{
				EPGIKGCADHM = other.EPGIKGCADHM;
			}
			dJDEBKPGJDN_.Add(other.dJDEBKPGJDN_);
			if (other.Time != 0L)
			{
				Time = other.Time;
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
			case 24u:
				Source = input.ReadUInt32();
				break;
			case 56u:
				GIIIGJFMHPO = input.ReadUInt32();
				break;
			case 88u:
				EPGIKGCADHM = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				dJDEBKPGJDN_.AddEntriesFrom(ref input, _repeated_dJDEBKPGJDN_codec);
				break;
			case 112u:
				Time = input.ReadInt64();
				break;
			}
		}
	}
}
