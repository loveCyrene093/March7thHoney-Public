using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LDPLIJAMIOE : IMessage<LDPLIJAMIOE>, IMessage, IEquatable<LDPLIJAMIOE>, IDeepCloneable<LDPLIJAMIOE>, IBufferMessage
{
	private static readonly MessageParser<LDPLIJAMIOE> _parser = new MessageParser<LDPLIJAMIOE>(() => new LDPLIJAMIOE());

	private UnknownFieldSet _unknownFields;

	public const int DCLAKCFJCPJFieldNumber = 2;

	private static readonly FieldCodec<OBNJKBMEAOL> _repeated_dCLAKCFJCPJ_codec = FieldCodec.ForMessage(18u, OBNJKBMEAOL.Parser);

	private readonly RepeatedField<OBNJKBMEAOL> dCLAKCFJCPJ_ = new RepeatedField<OBNJKBMEAOL>();

	public const int UniqueIdFieldNumber = 5;

	private int uniqueId_;

	public const int DMHLLKBMHELFieldNumber = 13;

	private uint dMHLLKBMHEL_;

	public const int EJCEIOMIOOPFieldNumber = 15;

	private AGBLLFGOBKE eJCEIOMIOOP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LDPLIJAMIOE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LDPLIJAMIOEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OBNJKBMEAOL> DCLAKCFJCPJ => dCLAKCFJCPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DMHLLKBMHEL
	{
		get
		{
			return dMHLLKBMHEL_;
		}
		set
		{
			dMHLLKBMHEL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGBLLFGOBKE EJCEIOMIOOP
	{
		get
		{
			return eJCEIOMIOOP_;
		}
		set
		{
			eJCEIOMIOOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LDPLIJAMIOE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LDPLIJAMIOE(LDPLIJAMIOE other)
		: this()
	{
		dCLAKCFJCPJ_ = other.dCLAKCFJCPJ_.Clone();
		uniqueId_ = other.uniqueId_;
		dMHLLKBMHEL_ = other.dMHLLKBMHEL_;
		eJCEIOMIOOP_ = ((other.eJCEIOMIOOP_ != null) ? other.eJCEIOMIOOP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LDPLIJAMIOE Clone()
	{
		return new LDPLIJAMIOE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LDPLIJAMIOE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LDPLIJAMIOE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dCLAKCFJCPJ_.Equals(other.dCLAKCFJCPJ_))
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (DMHLLKBMHEL != other.DMHLLKBMHEL)
		{
			return false;
		}
		if (!object.Equals(EJCEIOMIOOP, other.EJCEIOMIOOP))
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
		num ^= dCLAKCFJCPJ_.GetHashCode();
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (DMHLLKBMHEL != 0)
		{
			num ^= DMHLLKBMHEL.GetHashCode();
		}
		if (eJCEIOMIOOP_ != null)
		{
			num ^= EJCEIOMIOOP.GetHashCode();
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
		dCLAKCFJCPJ_.WriteTo(ref output, _repeated_dCLAKCFJCPJ_codec);
		if (UniqueId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(UniqueId);
		}
		if (DMHLLKBMHEL != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(DMHLLKBMHEL);
		}
		if (eJCEIOMIOOP_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(EJCEIOMIOOP);
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
		num += dCLAKCFJCPJ_.CalculateSize(_repeated_dCLAKCFJCPJ_codec);
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UniqueId);
		}
		if (DMHLLKBMHEL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DMHLLKBMHEL);
		}
		if (eJCEIOMIOOP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EJCEIOMIOOP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LDPLIJAMIOE other)
	{
		if (other == null)
		{
			return;
		}
		dCLAKCFJCPJ_.Add(other.dCLAKCFJCPJ_);
		if (other.UniqueId != 0)
		{
			UniqueId = other.UniqueId;
		}
		if (other.DMHLLKBMHEL != 0)
		{
			DMHLLKBMHEL = other.DMHLLKBMHEL;
		}
		if (other.eJCEIOMIOOP_ != null)
		{
			if (eJCEIOMIOOP_ == null)
			{
				EJCEIOMIOOP = new AGBLLFGOBKE();
			}
			EJCEIOMIOOP.MergeFrom(other.EJCEIOMIOOP);
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
			case 18u:
				dCLAKCFJCPJ_.AddEntriesFrom(ref input, _repeated_dCLAKCFJCPJ_codec);
				break;
			case 40u:
				UniqueId = input.ReadInt32();
				break;
			case 104u:
				DMHLLKBMHEL = input.ReadUInt32();
				break;
			case 122u:
				if (eJCEIOMIOOP_ == null)
				{
					EJCEIOMIOOP = new AGBLLFGOBKE();
				}
				input.ReadMessage(EJCEIOMIOOP);
				break;
			}
		}
	}
}
