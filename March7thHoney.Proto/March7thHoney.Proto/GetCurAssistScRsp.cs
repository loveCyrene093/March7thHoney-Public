using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetCurAssistScRsp : IMessage<GetCurAssistScRsp>, IMessage, IEquatable<GetCurAssistScRsp>, IDeepCloneable<GetCurAssistScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetCurAssistScRsp> _parser = new MessageParser<GetCurAssistScRsp>(() => new GetCurAssistScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ILPKPBOKMENFieldNumber = 5;

	private PlayerAssistInfo iLPKPBOKMEN_;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetCurAssistScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetCurAssistScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerAssistInfo ILPKPBOKMEN
	{
		get
		{
			return iLPKPBOKMEN_;
		}
		set
		{
			iLPKPBOKMEN_ = value;
		}
	}

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
	public GetCurAssistScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetCurAssistScRsp(GetCurAssistScRsp other)
		: this()
	{
		iLPKPBOKMEN_ = ((other.iLPKPBOKMEN_ != null) ? other.iLPKPBOKMEN_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetCurAssistScRsp Clone()
	{
		return new GetCurAssistScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetCurAssistScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetCurAssistScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ILPKPBOKMEN, other.ILPKPBOKMEN))
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
		if (iLPKPBOKMEN_ != null)
		{
			num ^= ILPKPBOKMEN.GetHashCode();
		}
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
		if (iLPKPBOKMEN_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(ILPKPBOKMEN);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
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
		if (iLPKPBOKMEN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ILPKPBOKMEN);
		}
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
	public void MergeFrom(GetCurAssistScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iLPKPBOKMEN_ != null)
		{
			if (iLPKPBOKMEN_ == null)
			{
				ILPKPBOKMEN = new PlayerAssistInfo();
			}
			ILPKPBOKMEN.MergeFrom(other.ILPKPBOKMEN);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (iLPKPBOKMEN_ == null)
				{
					ILPKPBOKMEN = new PlayerAssistInfo();
				}
				input.ReadMessage(ILPKPBOKMEN);
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
