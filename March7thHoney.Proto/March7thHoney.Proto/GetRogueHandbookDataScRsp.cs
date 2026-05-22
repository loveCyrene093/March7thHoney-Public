using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetRogueHandbookDataScRsp : IMessage<GetRogueHandbookDataScRsp>, IMessage, IEquatable<GetRogueHandbookDataScRsp>, IDeepCloneable<GetRogueHandbookDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetRogueHandbookDataScRsp> _parser = new MessageParser<GetRogueHandbookDataScRsp>(() => new GetRogueHandbookDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int IGFPODGEPIBFieldNumber = 9;

	private KMPCIKLJIHH iGFPODGEPIB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetRogueHandbookDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetRogueHandbookDataScRspReflection.Descriptor.MessageTypes[0];

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
	public KMPCIKLJIHH IGFPODGEPIB
	{
		get
		{
			return iGFPODGEPIB_;
		}
		set
		{
			iGFPODGEPIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueHandbookDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueHandbookDataScRsp(GetRogueHandbookDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		iGFPODGEPIB_ = ((other.iGFPODGEPIB_ != null) ? other.iGFPODGEPIB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueHandbookDataScRsp Clone()
	{
		return new GetRogueHandbookDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetRogueHandbookDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetRogueHandbookDataScRsp other)
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
		if (!object.Equals(IGFPODGEPIB, other.IGFPODGEPIB))
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
		if (iGFPODGEPIB_ != null)
		{
			num ^= IGFPODGEPIB.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (iGFPODGEPIB_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(IGFPODGEPIB);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (iGFPODGEPIB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IGFPODGEPIB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetRogueHandbookDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.iGFPODGEPIB_ != null)
		{
			if (iGFPODGEPIB_ == null)
			{
				IGFPODGEPIB = new KMPCIKLJIHH();
			}
			IGFPODGEPIB.MergeFrom(other.IGFPODGEPIB);
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
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 74u:
				if (iGFPODGEPIB_ == null)
				{
					IGFPODGEPIB = new KMPCIKLJIHH();
				}
				input.ReadMessage(IGFPODGEPIB);
				break;
			}
		}
	}
}
