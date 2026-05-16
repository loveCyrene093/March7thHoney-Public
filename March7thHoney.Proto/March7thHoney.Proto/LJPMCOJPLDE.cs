using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LJPMCOJPLDE : IMessage<LJPMCOJPLDE>, IMessage, IEquatable<LJPMCOJPLDE>, IDeepCloneable<LJPMCOJPLDE>, IBufferMessage
{
	private static readonly MessageParser<LJPMCOJPLDE> _parser = new MessageParser<LJPMCOJPLDE>(() => new LJPMCOJPLDE());

	private UnknownFieldSet _unknownFields;

	public const int IIPBCIPNHCIFieldNumber = 5;

	private static readonly FieldCodec<NADCNANJLBJ> _repeated_iIPBCIPNHCI_codec = FieldCodec.ForMessage(42u, NADCNANJLBJ.Parser);

	private readonly RepeatedField<NADCNANJLBJ> iIPBCIPNHCI_ = new RepeatedField<NADCNANJLBJ>();

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LJPMCOJPLDE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LJPMCOJPLDEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NADCNANJLBJ> IIPBCIPNHCI => iIPBCIPNHCI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LJPMCOJPLDE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LJPMCOJPLDE(LJPMCOJPLDE other)
		: this()
	{
		iIPBCIPNHCI_ = other.iIPBCIPNHCI_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LJPMCOJPLDE Clone()
	{
		return new LJPMCOJPLDE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LJPMCOJPLDE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LJPMCOJPLDE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iIPBCIPNHCI_.Equals(other.iIPBCIPNHCI_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= iIPBCIPNHCI_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		iIPBCIPNHCI_.WriteTo(ref output, _repeated_iIPBCIPNHCI_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
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
		num += iIPBCIPNHCI_.CalculateSize(_repeated_iIPBCIPNHCI_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LJPMCOJPLDE other)
	{
		if (other != null)
		{
			iIPBCIPNHCI_.Add(other.iIPBCIPNHCI_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 42u:
				iIPBCIPNHCI_.AddEntriesFrom(ref input, _repeated_iIPBCIPNHCI_codec);
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
