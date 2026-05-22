using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMaterialSubmitActivityDataScRsp : IMessage<GetMaterialSubmitActivityDataScRsp>, IMessage, IEquatable<GetMaterialSubmitActivityDataScRsp>, IDeepCloneable<GetMaterialSubmitActivityDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetMaterialSubmitActivityDataScRsp> _parser = new MessageParser<GetMaterialSubmitActivityDataScRsp>(() => new GetMaterialSubmitActivityDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int IHEKOKDPNPHFieldNumber = 10;

	private static readonly FieldCodec<HBPFFKNNLBC> _repeated_iHEKOKDPNPH_codec = FieldCodec.ForMessage(82u, HBPFFKNNLBC.Parser);

	private readonly RepeatedField<HBPFFKNNLBC> iHEKOKDPNPH_ = new RepeatedField<HBPFFKNNLBC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMaterialSubmitActivityDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMaterialSubmitActivityDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<HBPFFKNNLBC> IHEKOKDPNPH => iHEKOKDPNPH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMaterialSubmitActivityDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMaterialSubmitActivityDataScRsp(GetMaterialSubmitActivityDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		iHEKOKDPNPH_ = other.iHEKOKDPNPH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMaterialSubmitActivityDataScRsp Clone()
	{
		return new GetMaterialSubmitActivityDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMaterialSubmitActivityDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMaterialSubmitActivityDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!iHEKOKDPNPH_.Equals(other.iHEKOKDPNPH_))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= iHEKOKDPNPH_.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		iHEKOKDPNPH_.WriteTo(ref output, _repeated_iHEKOKDPNPH_codec);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += iHEKOKDPNPH_.CalculateSize(_repeated_iHEKOKDPNPH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetMaterialSubmitActivityDataScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			iHEKOKDPNPH_.Add(other.iHEKOKDPNPH_);
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
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 82u:
				iHEKOKDPNPH_.AddEntriesFrom(ref input, _repeated_iHEKOKDPNPH_codec);
				break;
			}
		}
	}
}
