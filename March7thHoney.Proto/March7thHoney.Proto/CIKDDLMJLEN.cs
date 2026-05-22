using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CIKDDLMJLEN : IMessage<CIKDDLMJLEN>, IMessage, IEquatable<CIKDDLMJLEN>, IDeepCloneable<CIKDDLMJLEN>, IBufferMessage
{
	private static readonly MessageParser<CIKDDLMJLEN> _parser = new MessageParser<CIKDDLMJLEN>(() => new CIKDDLMJLEN());

	private UnknownFieldSet _unknownFields;

	public const int MGDNOACBFOEFieldNumber = 1;

	private ulong mGDNOACBFOE_;

	public const int PLOBMBFPNFKFieldNumber = 2;

	private uint pLOBMBFPNFK_;

	public const int JMOMBDGIFDEFieldNumber = 3;

	private uint jMOMBDGIFDE_;

	public const int IOJCCKOLBHEFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_iOJCCKOLBHE_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> iOJCCKOLBHE_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CIKDDLMJLEN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CIKDDLMJLENReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong MGDNOACBFOE
	{
		get
		{
			return mGDNOACBFOE_;
		}
		set
		{
			mGDNOACBFOE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PLOBMBFPNFK
	{
		get
		{
			return pLOBMBFPNFK_;
		}
		set
		{
			pLOBMBFPNFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JMOMBDGIFDE
	{
		get
		{
			return jMOMBDGIFDE_;
		}
		set
		{
			jMOMBDGIFDE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IOJCCKOLBHE => iOJCCKOLBHE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIKDDLMJLEN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIKDDLMJLEN(CIKDDLMJLEN other)
		: this()
	{
		mGDNOACBFOE_ = other.mGDNOACBFOE_;
		pLOBMBFPNFK_ = other.pLOBMBFPNFK_;
		jMOMBDGIFDE_ = other.jMOMBDGIFDE_;
		iOJCCKOLBHE_ = other.iOJCCKOLBHE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIKDDLMJLEN Clone()
	{
		return new CIKDDLMJLEN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CIKDDLMJLEN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CIKDDLMJLEN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MGDNOACBFOE != other.MGDNOACBFOE)
		{
			return false;
		}
		if (PLOBMBFPNFK != other.PLOBMBFPNFK)
		{
			return false;
		}
		if (JMOMBDGIFDE != other.JMOMBDGIFDE)
		{
			return false;
		}
		if (!iOJCCKOLBHE_.Equals(other.iOJCCKOLBHE_))
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
		if (MGDNOACBFOE != 0L)
		{
			num ^= MGDNOACBFOE.GetHashCode();
		}
		if (PLOBMBFPNFK != 0)
		{
			num ^= PLOBMBFPNFK.GetHashCode();
		}
		if (JMOMBDGIFDE != 0)
		{
			num ^= JMOMBDGIFDE.GetHashCode();
		}
		num ^= iOJCCKOLBHE_.GetHashCode();
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
		if (MGDNOACBFOE != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(MGDNOACBFOE);
		}
		if (PLOBMBFPNFK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PLOBMBFPNFK);
		}
		if (JMOMBDGIFDE != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(JMOMBDGIFDE);
		}
		iOJCCKOLBHE_.WriteTo(ref output, _repeated_iOJCCKOLBHE_codec);
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
		if (MGDNOACBFOE != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(MGDNOACBFOE);
		}
		if (PLOBMBFPNFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PLOBMBFPNFK);
		}
		if (JMOMBDGIFDE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JMOMBDGIFDE);
		}
		num += iOJCCKOLBHE_.CalculateSize(_repeated_iOJCCKOLBHE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CIKDDLMJLEN other)
	{
		if (other != null)
		{
			if (other.MGDNOACBFOE != 0L)
			{
				MGDNOACBFOE = other.MGDNOACBFOE;
			}
			if (other.PLOBMBFPNFK != 0)
			{
				PLOBMBFPNFK = other.PLOBMBFPNFK;
			}
			if (other.JMOMBDGIFDE != 0)
			{
				JMOMBDGIFDE = other.JMOMBDGIFDE;
			}
			iOJCCKOLBHE_.Add(other.iOJCCKOLBHE_);
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
				MGDNOACBFOE = input.ReadUInt64();
				break;
			case 16u:
				PLOBMBFPNFK = input.ReadUInt32();
				break;
			case 24u:
				JMOMBDGIFDE = input.ReadUInt32();
				break;
			case 32u:
			case 34u:
				iOJCCKOLBHE_.AddEntriesFrom(ref input, _repeated_iOJCCKOLBHE_codec);
				break;
			}
		}
	}
}
