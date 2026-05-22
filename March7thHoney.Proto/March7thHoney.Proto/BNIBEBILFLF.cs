using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BNIBEBILFLF : IMessage<BNIBEBILFLF>, IMessage, IEquatable<BNIBEBILFLF>, IDeepCloneable<BNIBEBILFLF>, IBufferMessage
{
	private static readonly MessageParser<BNIBEBILFLF> _parser = new MessageParser<BNIBEBILFLF>(() => new BNIBEBILFLF());

	private UnknownFieldSet _unknownFields;

	public const int GNBLOHMPACLFieldNumber = 9;

	private uint gNBLOHMPACL_;

	public const int SwitchListFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_switchList_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> switchList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BNIBEBILFLF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BNIBEBILFLFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GNBLOHMPACL
	{
		get
		{
			return gNBLOHMPACL_;
		}
		set
		{
			gNBLOHMPACL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> SwitchList => switchList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNIBEBILFLF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNIBEBILFLF(BNIBEBILFLF other)
		: this()
	{
		gNBLOHMPACL_ = other.gNBLOHMPACL_;
		switchList_ = other.switchList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNIBEBILFLF Clone()
	{
		return new BNIBEBILFLF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BNIBEBILFLF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BNIBEBILFLF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GNBLOHMPACL != other.GNBLOHMPACL)
		{
			return false;
		}
		if (!switchList_.Equals(other.switchList_))
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
		if (GNBLOHMPACL != 0)
		{
			num ^= GNBLOHMPACL.GetHashCode();
		}
		num ^= switchList_.GetHashCode();
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
		if (GNBLOHMPACL != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GNBLOHMPACL);
		}
		switchList_.WriteTo(ref output, _repeated_switchList_codec);
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
		if (GNBLOHMPACL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GNBLOHMPACL);
		}
		num += switchList_.CalculateSize(_repeated_switchList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BNIBEBILFLF other)
	{
		if (other != null)
		{
			if (other.GNBLOHMPACL != 0)
			{
				GNBLOHMPACL = other.GNBLOHMPACL;
			}
			switchList_.Add(other.switchList_);
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
			case 72u:
				GNBLOHMPACL = input.ReadUInt32();
				break;
			case 112u:
			case 114u:
				switchList_.AddEntriesFrom(ref input, _repeated_switchList_codec);
				break;
			}
		}
	}
}
