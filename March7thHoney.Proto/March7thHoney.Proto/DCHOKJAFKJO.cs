using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DCHOKJAFKJO : IMessage<DCHOKJAFKJO>, IMessage, IEquatable<DCHOKJAFKJO>, IDeepCloneable<DCHOKJAFKJO>, IBufferMessage
{
	private static readonly MessageParser<DCHOKJAFKJO> _parser = new MessageParser<DCHOKJAFKJO>(() => new DCHOKJAFKJO());

	private UnknownFieldSet _unknownFields;

	public const int OMGPNOAINMBFieldNumber = 3;

	private static readonly FieldCodec<LHDMBIMGKCF> _repeated_oMGPNOAINMB_codec = FieldCodec.ForMessage(26u, LHDMBIMGKCF.Parser);

	private readonly RepeatedField<LHDMBIMGKCF> oMGPNOAINMB_ = new RepeatedField<LHDMBIMGKCF>();

	public const int DJODJOGJPBJFieldNumber = 5;

	private static readonly FieldCodec<MGEMFGLDJLJ> _repeated_dJODJOGJPBJ_codec = FieldCodec.ForMessage(42u, MGEMFGLDJLJ.Parser);

	private readonly RepeatedField<MGEMFGLDJLJ> dJODJOGJPBJ_ = new RepeatedField<MGEMFGLDJLJ>();

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DCHOKJAFKJO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DCHOKJAFKJOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LHDMBIMGKCF> OMGPNOAINMB => oMGPNOAINMB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MGEMFGLDJLJ> DJODJOGJPBJ => dJODJOGJPBJ_;

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
	public DCHOKJAFKJO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCHOKJAFKJO(DCHOKJAFKJO other)
		: this()
	{
		oMGPNOAINMB_ = other.oMGPNOAINMB_.Clone();
		dJODJOGJPBJ_ = other.dJODJOGJPBJ_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCHOKJAFKJO Clone()
	{
		return new DCHOKJAFKJO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DCHOKJAFKJO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DCHOKJAFKJO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!oMGPNOAINMB_.Equals(other.oMGPNOAINMB_))
		{
			return false;
		}
		if (!dJODJOGJPBJ_.Equals(other.dJODJOGJPBJ_))
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
		num ^= oMGPNOAINMB_.GetHashCode();
		num ^= dJODJOGJPBJ_.GetHashCode();
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
		oMGPNOAINMB_.WriteTo(ref output, _repeated_oMGPNOAINMB_codec);
		dJODJOGJPBJ_.WriteTo(ref output, _repeated_dJODJOGJPBJ_codec);
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
		num += oMGPNOAINMB_.CalculateSize(_repeated_oMGPNOAINMB_codec);
		num += dJODJOGJPBJ_.CalculateSize(_repeated_dJODJOGJPBJ_codec);
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
	public void MergeFrom(DCHOKJAFKJO other)
	{
		if (other != null)
		{
			oMGPNOAINMB_.Add(other.oMGPNOAINMB_);
			dJODJOGJPBJ_.Add(other.dJODJOGJPBJ_);
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
			case 26u:
				oMGPNOAINMB_.AddEntriesFrom(ref input, _repeated_oMGPNOAINMB_codec);
				break;
			case 42u:
				dJODJOGJPBJ_.AddEntriesFrom(ref input, _repeated_dJODJOGJPBJ_codec);
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
