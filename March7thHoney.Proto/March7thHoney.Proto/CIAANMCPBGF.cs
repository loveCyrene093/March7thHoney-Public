using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CIAANMCPBGF : IMessage<CIAANMCPBGF>, IMessage, IEquatable<CIAANMCPBGF>, IDeepCloneable<CIAANMCPBGF>, IBufferMessage
{
	private static readonly MessageParser<CIAANMCPBGF> _parser = new MessageParser<CIAANMCPBGF>(() => new CIAANMCPBGF());

	private UnknownFieldSet _unknownFields;

	public const int NKDEMKAPNMNFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_nKDEMKAPNMN_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> nKDEMKAPNMN_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CIAANMCPBGF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CIAANMCPBGFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NKDEMKAPNMN => nKDEMKAPNMN_;

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
	public CIAANMCPBGF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIAANMCPBGF(CIAANMCPBGF other)
		: this()
	{
		nKDEMKAPNMN_ = other.nKDEMKAPNMN_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIAANMCPBGF Clone()
	{
		return new CIAANMCPBGF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CIAANMCPBGF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CIAANMCPBGF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nKDEMKAPNMN_.Equals(other.nKDEMKAPNMN_))
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
		num ^= nKDEMKAPNMN_.GetHashCode();
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
		nKDEMKAPNMN_.WriteTo(ref output, _repeated_nKDEMKAPNMN_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
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
		num += nKDEMKAPNMN_.CalculateSize(_repeated_nKDEMKAPNMN_codec);
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
	public void MergeFrom(CIAANMCPBGF other)
	{
		if (other != null)
		{
			nKDEMKAPNMN_.Add(other.nKDEMKAPNMN_);
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
			case 72u:
			case 74u:
				nKDEMKAPNMN_.AddEntriesFrom(ref input, _repeated_nKDEMKAPNMN_codec);
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
