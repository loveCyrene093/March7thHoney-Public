using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KEKKIEFKKGO : IMessage<KEKKIEFKKGO>, IMessage, IEquatable<KEKKIEFKKGO>, IDeepCloneable<KEKKIEFKKGO>, IBufferMessage
{
	private static readonly MessageParser<KEKKIEFKKGO> _parser = new MessageParser<KEKKIEFKKGO>(() => new KEKKIEFKKGO());

	private UnknownFieldSet _unknownFields;

	public const int MBPOPEEJPJIFieldNumber = 2;

	private DFLMKFIFHKB mBPOPEEJPJI_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KEKKIEFKKGO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KEKKIEFKKGOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFLMKFIFHKB MBPOPEEJPJI
	{
		get
		{
			return mBPOPEEJPJI_;
		}
		set
		{
			mBPOPEEJPJI_ = value;
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
	public KEKKIEFKKGO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEKKIEFKKGO(KEKKIEFKKGO other)
		: this()
	{
		mBPOPEEJPJI_ = ((other.mBPOPEEJPJI_ != null) ? other.mBPOPEEJPJI_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEKKIEFKKGO Clone()
	{
		return new KEKKIEFKKGO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KEKKIEFKKGO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KEKKIEFKKGO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MBPOPEEJPJI, other.MBPOPEEJPJI))
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
		if (mBPOPEEJPJI_ != null)
		{
			num ^= MBPOPEEJPJI.GetHashCode();
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
		if (mBPOPEEJPJI_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MBPOPEEJPJI);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
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
		if (mBPOPEEJPJI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MBPOPEEJPJI);
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
	public void MergeFrom(KEKKIEFKKGO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mBPOPEEJPJI_ != null)
		{
			if (mBPOPEEJPJI_ == null)
			{
				MBPOPEEJPJI = new DFLMKFIFHKB();
			}
			MBPOPEEJPJI.MergeFrom(other.MBPOPEEJPJI);
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
			case 18u:
				if (mBPOPEEJPJI_ == null)
				{
					MBPOPEEJPJI = new DFLMKFIFHKB();
				}
				input.ReadMessage(MBPOPEEJPJI);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
