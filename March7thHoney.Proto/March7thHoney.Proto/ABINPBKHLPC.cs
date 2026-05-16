using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ABINPBKHLPC : IMessage<ABINPBKHLPC>, IMessage, IEquatable<ABINPBKHLPC>, IDeepCloneable<ABINPBKHLPC>, IBufferMessage
{
	private static readonly MessageParser<ABINPBKHLPC> _parser = new MessageParser<ABINPBKHLPC>(() => new ABINPBKHLPC());

	private UnknownFieldSet _unknownFields;

	public const int KBBPNKGGCPNFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_kBBPNKGGCPN_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> kBBPNKGGCPN_ = new RepeatedField<uint>();

	public const int OPHPMKFGLBAFieldNumber = 14;

	private uint oPHPMKFGLBA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ABINPBKHLPC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ABINPBKHLPCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> KBBPNKGGCPN => kBBPNKGGCPN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OPHPMKFGLBA
	{
		get
		{
			return oPHPMKFGLBA_;
		}
		set
		{
			oPHPMKFGLBA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ABINPBKHLPC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ABINPBKHLPC(ABINPBKHLPC other)
		: this()
	{
		kBBPNKGGCPN_ = other.kBBPNKGGCPN_.Clone();
		oPHPMKFGLBA_ = other.oPHPMKFGLBA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ABINPBKHLPC Clone()
	{
		return new ABINPBKHLPC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ABINPBKHLPC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ABINPBKHLPC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kBBPNKGGCPN_.Equals(other.kBBPNKGGCPN_))
		{
			return false;
		}
		if (OPHPMKFGLBA != other.OPHPMKFGLBA)
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
		num ^= kBBPNKGGCPN_.GetHashCode();
		if (OPHPMKFGLBA != 0)
		{
			num ^= OPHPMKFGLBA.GetHashCode();
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
		kBBPNKGGCPN_.WriteTo(ref output, _repeated_kBBPNKGGCPN_codec);
		if (OPHPMKFGLBA != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(OPHPMKFGLBA);
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
		num += kBBPNKGGCPN_.CalculateSize(_repeated_kBBPNKGGCPN_codec);
		if (OPHPMKFGLBA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OPHPMKFGLBA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ABINPBKHLPC other)
	{
		if (other != null)
		{
			kBBPNKGGCPN_.Add(other.kBBPNKGGCPN_);
			if (other.OPHPMKFGLBA != 0)
			{
				OPHPMKFGLBA = other.OPHPMKFGLBA;
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
			case 58u:
				kBBPNKGGCPN_.AddEntriesFrom(ref input, _repeated_kBBPNKGGCPN_codec);
				break;
			case 112u:
				OPHPMKFGLBA = input.ReadUInt32();
				break;
			}
		}
	}
}
