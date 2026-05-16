using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PunkLordDataChangeNotify : IMessage<PunkLordDataChangeNotify>, IMessage, IEquatable<PunkLordDataChangeNotify>, IDeepCloneable<PunkLordDataChangeNotify>, IBufferMessage
{
	private static readonly MessageParser<PunkLordDataChangeNotify> _parser = new MessageParser<PunkLordDataChangeNotify>(() => new PunkLordDataChangeNotify());

	private UnknownFieldSet _unknownFields;

	public const int CLMONEEIEJEFieldNumber = 4;

	private uint cLMONEEIEJE_;

	public const int EJFEBCKDNNHFieldNumber = 7;

	private uint eJFEBCKDNNH_;

	public const int DBAKNBHLNJKFieldNumber = 12;

	private uint dBAKNBHLNJK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PunkLordDataChangeNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PunkLordDataChangeNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CLMONEEIEJE
	{
		get
		{
			return cLMONEEIEJE_;
		}
		set
		{
			cLMONEEIEJE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EJFEBCKDNNH
	{
		get
		{
			return eJFEBCKDNNH_;
		}
		set
		{
			eJFEBCKDNNH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DBAKNBHLNJK
	{
		get
		{
			return dBAKNBHLNJK_;
		}
		set
		{
			dBAKNBHLNJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordDataChangeNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordDataChangeNotify(PunkLordDataChangeNotify other)
		: this()
	{
		cLMONEEIEJE_ = other.cLMONEEIEJE_;
		eJFEBCKDNNH_ = other.eJFEBCKDNNH_;
		dBAKNBHLNJK_ = other.dBAKNBHLNJK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordDataChangeNotify Clone()
	{
		return new PunkLordDataChangeNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PunkLordDataChangeNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PunkLordDataChangeNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CLMONEEIEJE != other.CLMONEEIEJE)
		{
			return false;
		}
		if (EJFEBCKDNNH != other.EJFEBCKDNNH)
		{
			return false;
		}
		if (DBAKNBHLNJK != other.DBAKNBHLNJK)
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
		if (CLMONEEIEJE != 0)
		{
			num ^= CLMONEEIEJE.GetHashCode();
		}
		if (EJFEBCKDNNH != 0)
		{
			num ^= EJFEBCKDNNH.GetHashCode();
		}
		if (DBAKNBHLNJK != 0)
		{
			num ^= DBAKNBHLNJK.GetHashCode();
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
		if (CLMONEEIEJE != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CLMONEEIEJE);
		}
		if (EJFEBCKDNNH != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(EJFEBCKDNNH);
		}
		if (DBAKNBHLNJK != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(DBAKNBHLNJK);
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
		if (CLMONEEIEJE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CLMONEEIEJE);
		}
		if (EJFEBCKDNNH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EJFEBCKDNNH);
		}
		if (DBAKNBHLNJK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DBAKNBHLNJK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PunkLordDataChangeNotify other)
	{
		if (other != null)
		{
			if (other.CLMONEEIEJE != 0)
			{
				CLMONEEIEJE = other.CLMONEEIEJE;
			}
			if (other.EJFEBCKDNNH != 0)
			{
				EJFEBCKDNNH = other.EJFEBCKDNNH;
			}
			if (other.DBAKNBHLNJK != 0)
			{
				DBAKNBHLNJK = other.DBAKNBHLNJK;
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
			case 32u:
				CLMONEEIEJE = input.ReadUInt32();
				break;
			case 56u:
				EJFEBCKDNNH = input.ReadUInt32();
				break;
			case 96u:
				DBAKNBHLNJK = input.ReadUInt32();
				break;
			}
		}
	}
}
