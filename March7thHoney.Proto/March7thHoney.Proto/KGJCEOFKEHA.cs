using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KGJCEOFKEHA : IMessage<KGJCEOFKEHA>, IMessage, IEquatable<KGJCEOFKEHA>, IDeepCloneable<KGJCEOFKEHA>, IBufferMessage
{
	private static readonly MessageParser<KGJCEOFKEHA> _parser = new MessageParser<KGJCEOFKEHA>(() => new KGJCEOFKEHA());

	private UnknownFieldSet _unknownFields;

	public const int MHMDIDKNCIHFieldNumber = 3;

	private PBPIOFGODHC mHMDIDKNCIH_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KGJCEOFKEHA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KGJCEOFKEHAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBPIOFGODHC MHMDIDKNCIH
	{
		get
		{
			return mHMDIDKNCIH_;
		}
		set
		{
			mHMDIDKNCIH_ = value;
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
	public KGJCEOFKEHA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGJCEOFKEHA(KGJCEOFKEHA other)
		: this()
	{
		mHMDIDKNCIH_ = ((other.mHMDIDKNCIH_ != null) ? other.mHMDIDKNCIH_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGJCEOFKEHA Clone()
	{
		return new KGJCEOFKEHA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KGJCEOFKEHA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KGJCEOFKEHA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MHMDIDKNCIH, other.MHMDIDKNCIH))
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
		if (mHMDIDKNCIH_ != null)
		{
			num ^= MHMDIDKNCIH.GetHashCode();
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
		if (mHMDIDKNCIH_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MHMDIDKNCIH);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
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
		if (mHMDIDKNCIH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MHMDIDKNCIH);
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
	public void MergeFrom(KGJCEOFKEHA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mHMDIDKNCIH_ != null)
		{
			if (mHMDIDKNCIH_ == null)
			{
				MHMDIDKNCIH = new PBPIOFGODHC();
			}
			MHMDIDKNCIH.MergeFrom(other.MHMDIDKNCIH);
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
			case 26u:
				if (mHMDIDKNCIH_ == null)
				{
					MHMDIDKNCIH = new PBPIOFGODHC();
				}
				input.ReadMessage(MHMDIDKNCIH);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
