using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BKNPGKNIOMG : IMessage<BKNPGKNIOMG>, IMessage, IEquatable<BKNPGKNIOMG>, IDeepCloneable<BKNPGKNIOMG>, IBufferMessage
{
	private static readonly MessageParser<BKNPGKNIOMG> _parser = new MessageParser<BKNPGKNIOMG>(() => new BKNPGKNIOMG());

	private UnknownFieldSet _unknownFields;

	public const int EKIMLIAMFHEFieldNumber = 1;

	private uint eKIMLIAMFHE_;

	public const int PDMMDNJMIKMFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_pDMMDNJMIKM_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> pDMMDNJMIKM_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BKNPGKNIOMG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BKNPGKNIOMGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EKIMLIAMFHE
	{
		get
		{
			return eKIMLIAMFHE_;
		}
		set
		{
			eKIMLIAMFHE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PDMMDNJMIKM => pDMMDNJMIKM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BKNPGKNIOMG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BKNPGKNIOMG(BKNPGKNIOMG other)
		: this()
	{
		eKIMLIAMFHE_ = other.eKIMLIAMFHE_;
		pDMMDNJMIKM_ = other.pDMMDNJMIKM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BKNPGKNIOMG Clone()
	{
		return new BKNPGKNIOMG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BKNPGKNIOMG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BKNPGKNIOMG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EKIMLIAMFHE != other.EKIMLIAMFHE)
		{
			return false;
		}
		if (!pDMMDNJMIKM_.Equals(other.pDMMDNJMIKM_))
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
		if (EKIMLIAMFHE != 0)
		{
			num ^= EKIMLIAMFHE.GetHashCode();
		}
		num ^= pDMMDNJMIKM_.GetHashCode();
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
		if (EKIMLIAMFHE != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EKIMLIAMFHE);
		}
		pDMMDNJMIKM_.WriteTo(ref output, _repeated_pDMMDNJMIKM_codec);
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
		if (EKIMLIAMFHE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EKIMLIAMFHE);
		}
		num += pDMMDNJMIKM_.CalculateSize(_repeated_pDMMDNJMIKM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BKNPGKNIOMG other)
	{
		if (other != null)
		{
			if (other.EKIMLIAMFHE != 0)
			{
				EKIMLIAMFHE = other.EKIMLIAMFHE;
			}
			pDMMDNJMIKM_.Add(other.pDMMDNJMIKM_);
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
				EKIMLIAMFHE = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				pDMMDNJMIKM_.AddEntriesFrom(ref input, _repeated_pDMMDNJMIKM_codec);
				break;
			}
		}
	}
}
